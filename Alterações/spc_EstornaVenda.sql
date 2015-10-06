USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spc_EstornaVenda]    Script Date: 04/10/2015 15:17:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spc_EstornaVenda]
	(
	@CodVenda int,
	@CodProduto int,
	@DesMotivo varchar(100)
	)
AS
	SET NOCOUNT ON
	
	IF @CodProduto = '' SET @CodProduto = NULL
	
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
	WHERE CodVenda = @CodVenda AND
			codigounico = IsNull(@CodProduto, codigounico)
	
	DELETE FROM tbl_SaidaItens
	WHERE CodVenda = @CodVenda AND
			codigounico = IsNull(@CodProduto, codigounico)
	
	
	RETURN

