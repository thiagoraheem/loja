# Análise técnica do fluxo de vendas e NFC-e

## Resumo executivo

O fluxo atual de vendas + NFC-e possui uma base funcional, mas com fragilidades importantes em idempotência, conciliação pós-falha e consistência entre banco e SEFAZ. Os principais riscos estavam em:

1. **Possibilidade de reenvio indevido** de notas já autorizadas (normal e contingência) por ausência de guarda de idempotência antes de transmitir.
2. **Tratamento insuficiente de duplicidade (cStat 204)**, que podia manter o banco inconsistente mesmo com nota já autorizada na SEFAZ.
3. **`cNF` não determinístico e com baixa entropia (até 4 dígitos)**, elevando risco operacional de divergência/duplicidade em retransmissões após timeout.
4. **NRE em consulta de venda inexistente**, prejudicando robustez em reconciliação e recuperação de incidentes.

As melhorias implementadas priorizaram abordagem conservadora e fiscalmente segura: reconciliação por chave antes de transmitir, atualização transacional de status autorizado após confirmação externa, prevenção explícita de reenvio quando já autorizado e geração determinística de `cNF`.

---

## Mapeamento do fluxo atual

### 1) Venda

1. O usuário finaliza o orçamento em `frmVenda`.
2. O sistema chama `Cadastros.FinalizaVenda(...)`, gerando a venda no banco.
3. Em seguida carrega a venda com itens via `Consultas.ObterVenda(codVenda)`.
4. Se marcado para NFC-e, instancia `Modules.NFCE` e chama `EnviaNFCE(...)`.

### 2) Emissão normal (tpEmis normal)

1. Monta objeto NFe (`GetNf`/`GetInf`/`GetIdentificacao` etc.).
2. Assina XML (`_nfe.Assina()`).
3. Transmite lote (`NFeAutorizacao`).
4. Consulta recibo (`NFeRetAutorizacao`) com tentativas curtas.
5. Consulta protocolo por chave (`NfeConsultaProtocolo`).
6. Gera `-procNfe.xml`, imprime DANFE e atualiza venda (`FlgStatusNFE="A"`, chave e protocolo).

### 3) Contingência offline

1. Em `tpEmis != normal`, marca status `C`.
2. Valida e salva XML local `-cont.xml`.
3. Imprime DANFE em contingência.
4. Persistência da venda com chave e status.

### 4) Reenvio de contingência

1. Busca vendas com `FlgStatusNFE == "C"`.
2. Reconstroi NFC-e, assina e envia lote.
3. Consulta recibo/protocolo.
4. Atualiza status para `A` e salva protocolo/chave.

### 5) Cancelamento

1. Tela `frmVendas` valida janela de tempo e status.
2. `NFCE.CancelarNFe(...)` envia evento de cancelamento.
3. Em sucesso, `Cadastros.CancelarVenda(...)` altera status local para cancelada.

---

## Problemas encontrados (diagnóstico)

## P1 — Falta de guarda idempotente antes da transmissão

- **Descrição:** não havia verificação prévia robusta para evitar retransmitir nota já autorizada.
- **Impacto:** reenvios indevidos, ruído operacional, risco de divergência e tratamento manual.
- **Risco fiscal/operacional:** médio/alto.
- **Causa provável:** foco em fluxo happy path sem reconciliação pré-transmissão.
- **Recomendação:** antes de transmitir, verificar status local e conciliar por chave na SEFAZ quando existir.

## P2 — Duplicidade (cStat 204) sem reconciliação automática

- **Descrição:** retorno de duplicidade era tratado como erro terminal.
- **Impacto:** nota potencialmente autorizada na SEFAZ enquanto banco permanecia não autorizado.
- **Risco fiscal/operacional:** alto.
- **Causa provável:** ausência de máquina de decisão para códigos de retorno críticos.
- **Recomendação:** ao receber 204, consultar protocolo da chave, e se autorizado (100), reconciliar banco.

## P3 — `cNF` randômico fraco

- **Descrição:** `cNF` era gerado com `Random().Next(9999)` (até 4 dígitos), não determinístico entre tentativas.
- **Impacto:** risco de chave diferente entre reprocessamentos e maior chance de inconsistência pós-timeout.
- **Risco fiscal/operacional:** alto.
- **Causa provável:** implementação simplificada de teste não endurecida para produção.
- **Recomendação:** usar `cNF` determinístico por venda (8 dígitos), preservando idempotência de chave.

## P4 — Possível `NullReferenceException` em consulta de venda

- **Descrição:** `Consultas.ObterVenda` iterava itens mesmo quando venda não existia.
- **Impacto:** falha abrupta em cenários de reconciliação/reprocessamento.
- **Risco fiscal/operacional:** médio.
- **Causa provável:** ausência de proteção defensiva para resultado nulo.
- **Recomendação:** retorno imediato de `null` com validação nos chamadores.

---

## Melhorias implementadas

## M1 — Reconciliação pré-envio por chave

Implementado em `NFCE` método de conciliação com consulta de protocolo antes de nova transmissão. Se já autorizado na SEFAZ (cStat 100), atualiza banco (`FlgStatusNFE`, `NumProtocolo`, `ChaveSefaz`) e retorna sucesso idempotente.

**Risco mitigado:** divergência banco × SEFAZ após timeout/queda.

## M2 — Bloqueio de reenvio quando já autorizado

Tanto no fluxo normal quanto no fluxo de contingência, se a venda já consta `A` + protocolo, a rotina encerra sem retransmitir.

**Risco mitigado:** duplicidade operacional e retrabalho fiscal.

## M3 — Tratamento conservador de cStat 204

Nos loops de retorno de lote (normal e contingência), `cStat 204` agora aciona reconciliação automática por chave. Se autorizada na SEFAZ, retorna sucesso e atualiza banco.

**Risco mitigado:** estado "erro local" com autorização real na SEFAZ.

## M4 — `cNF` determinístico (8 dígitos)

Substituída a geração randômica frágil por código numérico determinístico (`SHA-256` da origem da venda, módulo 100000000, formatado `D8`).

**Risco mitigado:** perda de idempotência de chave e inconsistências em retransmissões.

## M5 — Robustez em `ObterVenda`

Adicionada proteção contra `null` antes de iterar itens em `Consultas.ObterVenda`.

**Risco mitigado:** falha abrupta em reconciliação/automação.

---

## Pendências desenvolvidas nesta iteração

1. **Trava lógica por venda (lock em memória por `CodVenda`)** implementada no módulo de emissão para evitar processamento concorrente simultâneo da mesma NFC-e.
2. **Fila persistente de retry** implementada em arquivo (`retry-queue.txt`) com reprocessamento automático quando conexão/SEFAZ normalizam.
3. **Logs estruturados de auditoria** implementados em arquivo JSONL (`Logs/Nfce/nfce-audit-YYYYMMDD.log`) com evento, status, venda, detalhe e exceção.
4. **Reconciliação automática periódica** reforçada no monitor da aplicação principal para processar contingências + fila de retry.
5. **Máquina de estados explícita** implementada para validar transições de status NFC-e de forma conservadora antes de persistir no banco.

## Riscos remanescentes

1. Persistência de XML/protocolos ainda orientada a filesystem local (não transacional).
2. Ausência de lock distribuído entre múltiplas instâncias da aplicação (trava atual é local ao processo).
3. Retry com fila local não substitui um barramento transacional corporativo (outbox em banco + worker dedicado).

---

## Priorização recomendada (próximas iterações)

1. **Alta:** máquina de estados explícita NFC-e (`PendenteEnvio`, `EmProcessamento`, `Autorizada`, `Rejeitada`, `Cancelada`, `ContingenciaPendente`, `ErroRecuperavel`, `ErroNaoRecuperavel`).
2. **Alta:** trava lógica por `CodVenda` (mutex distribuído/local + marcação no banco).
3. **Alta:** reconciliação agendada com SEFAZ para notas em `C`, sem protocolo, ou com erro recuperável.
4. **Média:** observabilidade/auditoria estruturada (logs com evento, tentativa, duração, endpoint, hash xml, cStat).
5. **Média:** políticas de retry com jitter/backoff e limite por tipo de erro.

---

## Conclusão

As mudanças aplicadas elevam significativamente a confiabilidade fiscal do fluxo atual sem alterar a arquitetura global da aplicação. O principal ganho está na **idempotência e reconciliação conservadora**, reduzindo o risco de divergência entre o banco interno e o estado real da NFC-e na SEFAZ, especialmente em cenários de contingência, timeout e duplicidade.
