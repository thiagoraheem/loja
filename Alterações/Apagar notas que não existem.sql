delete from a
from tbl_SaidaItens a
where codvenda in (select codvenda from tbl_Saida_Hist)

delete from a
from tbl_Saida a
where codvenda in (select codvenda from tbl_Saida_Hist)