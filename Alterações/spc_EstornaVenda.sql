USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spc_EstornaVenda]    Script Date: 04/11/2015 17:12:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spc_EstornaVenda]
	(
	@CodVenda varchar(10),
	@DesMotivo varchar(100),
	@flgVoltaNumero bit
	)
AS
	SET NOCOUNT ON
		
	UPDATE tbl_Produtos
	SET QtdProduto = QtdProduto + Quantidade
	FROM tbl_Produtos p
	INNER JOIN tbl_SaidaItens i ON
		i.codigounico = p.codigounico
	WHERE CodVenda = @CodVenda
	
	INSERT INTO tbl_SaidasEstorno (CodVenda, DatSaida, CodOrcamento, CodProduto, DesProduto,
									VlrUnitario, Quantidade, VlrCusto, CodTipoVenda,
									DatEstorno, MotivoEstorno, codigounico)
	SELECT CodVenda, DatSaida, CodOrcamento, CodProduto, DesProduto, VlrUnitario, 
			Quantidade, VlrCusto, -1, GetDate(), @DesMotivo, codigounico
	FROM tbl_SaidaItens
	WHERE CodVenda = @CodVenda --AND codigounico = IsNull(@CodProduto, codigounico)
	
	DELETE FROM tbl_SaidaItens
	WHERE CodVenda = @CodVenda --AND codigounico = IsNull(@CodProduto, codigounico)
	
	DELETE FROM tbl_Saida WHERE CodVenda = @CodVenda
	
	IF @flgVoltaNumero = 1 BEGIN

		UPDATE tbl_Parametros  SET  SisCodVenda = SisCodVenda - 1

	END

	RETURN

