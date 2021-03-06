USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spc_AlterarOrcamento]    Script Date: 08/12/2013 14:03:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spc_AlterarOrcamento]
	@CodOrca		VARCHAR(5),
	@CodProduto		int,
	@Quantidade		FLOAT = -1,
	@VlrUnitario	FLOAT = -1

AS

SET NOCOUNT ON

DECLARE @QtdEstoque FLOAT

SELECT @QtdEstoque = QtdProduto FROM tbl_Produtos WHERE codigounico = @CodProduto

IF @QtdEstoque < @Quantidade BEGIN
	RAISERROR('QUANTIDADE MAIOR QUE O DISPONÍVEL EM ESTOQUE', 16, 1)
	RETURN
END


IF ISNULL(@Quantidade, -1) > -1
	IF @Quantidade > 0
		UPDATE tbl_Orcamento 
		SET Quantidade = @Quantidade
		WHERE CodOrca = @CodOrca AND 
				codigounico = @CodProduto
	ELSE
		DELETE FROM tbl_Orcamento
		WHERE CodOrca = @CodOrca AND 
				codigounico = @CodProduto

IF ISNULL(@VlrUnitario, -1) > -1
	
	UPDATE tbl_Orcamento 
	SET VlrUnitario = @VlrUnitario
	WHERE CodOrca = @CodOrca AND
			codigounico = @CodProduto
