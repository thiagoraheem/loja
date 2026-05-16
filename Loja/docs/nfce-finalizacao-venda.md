# Finalização de Venda com NFC-e (Garantia de tbl_Saida)

## Objetivo

Garantir que toda NFC-e autorizada pela SEFAZ tenha obrigatoriamente um registro correspondente em `tbl_Saida`, mesmo que ocorram falhas em etapas posteriores (ex.: geração de PROC, impressão do DANFE, geração de PDF).

## Fluxo atual (pontos de entrada)

- Tela “Finalizar Venda”: [frmVenda.btnFinalizarVenda_Click](file:///c:/Projetos/loja/Loja/Loja/Forms/frmVenda.cs#L77-L221)
- Emissão NFC-e: [NFCE.EnviaNFCE](file:///c:/Projetos/loja/Loja/Loja/Modules/NFCE.cs#L82-L313)

## Fluxo de finalização (mapeamento ponta-a-ponta)

1. Usuário clica em “Finalizar Venda”.
2. A aplicação grava/identifica o cliente (opcional).
3. A aplicação executa a finalização no banco:
   - [Cadastros.FinalizaVenda](file:///c:/Projetos/loja/Loja/Loja.DAL/DAO/Cadastros.cs#L275-L282) → `spc_FinalizaVenda`
   - A stored procedure insere `tbl_Saida` e `tbl_SaidaItens` e atualiza estoque.
4. A aplicação carrega a venda recém-finalizada:
   - [Consultas.ObterVenda](file:///c:/Projetos/loja/Loja/Loja.DAL/DAO/Consultas.cs#L256-L277)
5. Se “Emitir NFC-e” estiver marcado, a aplicação dispara a emissão:
   - [NFCE.EnviaNFCE](file:///c:/Projetos/loja/Loja/Loja/Modules/NFCE.cs#L82-L313)
6. Emissão na SEFAZ (modo normal):
   - Envia lote: `NFeAutorizacao`
   - Consulta recibo: `NFeRetAutorizacao`
   - Consulta protocolo: `NfeConsultaProtocolo`
7. Persistência local pós-autorização:
   - Atualiza `tbl_Saida` com `FlgStatusNFE = "A"`, `ChaveSefaz` e `NumProtocolo`
8. Pós-processamento:
   - Geração do `*-procNfe.xml`
   - Impressão do DANFE / geração de PDF

## Causa raiz do problema (registro ausente em tbl_Saida)

O fluxo anterior tratava falhas de pós-processamento como “falha de emissão” e disparava estorno automático da venda na UI. Como a autorização na SEFAZ já podia ter ocorrido, o estorno removia `tbl_Saida`, gerando divergência: NFC-e autorizada na SEFAZ sem registro local.

Um gatilho frequente era incompatibilidade de versões do pacote `Zeus.Net.NFe.NFCe` entre projetos (executável e bibliotecas de DANFE), levando a exceção em runtime (“Method not found … CarregarDeXmlString …”) durante a impressão/carregamento do XML.

## Novo comportamento (contingência/rollback condicional)

- A venda não é mais estornada automaticamente quando a emissão falha.
- Após a SEFAZ autorizar (protocolo 100), a aplicação persiste imediatamente:
  - `FlgStatusNFE = "A"`
  - `ChaveSefaz`
  - `NumProtocolo`
- Erros posteriores (PROC/impressão/PDF) não invalidam a autorização:
  - O processo retorna sucesso com mensagem de pós-processamento.
  - Logs de auditoria são gravados em `Logs\\Nfce\\nfce-audit-YYYYMMDD.log`.

## Proteção contra exclusão acidental

- `Cadastros.EstornaVenda` e `Cadastros.ExcluirVenda` bloqueiam operações quando a NFC-e está autorizada (status “A” com protocolo).

## Rotinas de verificação e recuperação

- Reprocessamento automático:
  - Falhas em emissão enfileiram o `codVenda` em `Logs\\Nfce\\retry-queue.txt`, consumido pelo monitor na tela principal.
- Autocorreção defensiva:
  - `Cadastros.AtualizaStatusNFE` cria um registro mínimo de `tbl_Saida` caso ele não exista no momento da atualização de status (evita quebra do fluxo de conciliação/retry).
- Auditoria automática por PROC XML:
  - A rotina [NfceSaidaAuditor.ReconciliarProcXmls](file:///c:/Projetos/loja/Loja/Loja/Modules/NfceSaidaAuditor.cs) varre `*-procNfe.xml` no diretório de XML e garante `tbl_Saida` para cada NFC-e autorizada encontrada.
  - Ela é executada periodicamente pelo monitor na tela principal: [frmPrincipal.VerificaStatus](file:///c:/Projetos/loja/Loja/Loja/Forms/frmPrincipal.cs#L142-L174).
  - Os arquivos `*-procNfe.xml` processados são arquivados automaticamente em `_procNfe_processado\\YYYYMMDD` dentro do diretório de XML, eliminando a necessidade de exclusão manual.
  - Notificações foram tornadas não intrusivas:
    - Não exibe mensagem quando apenas reconciliou/arquivou com sucesso.
    - Exibe aviso apenas em falhas reais de leitura/reconciliação.
    - Aplica limitação por dia e intervalo mínimo entre avisos (estado em `Logs\\Nfce\\procxml-audit-state.txt`).

## Testes

- Build com warnings-as-errors:
  - `dotnet build .\\Loja.sln -c Release /warnaserror`
- Testes existentes:
  - `dotnet test .\\Loja.sln -c Release --no-build`
