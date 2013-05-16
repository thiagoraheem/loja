USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spc_AdicionarEntrada]    Script Date: 05/15/2013 19:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spc_AdicionarEntrada]
(
	@DocEntrada		varchar(15),
	@DatEntrada		smalldatetime,
	@CodProduto		int,
	@QtdProduto		float,
	@VlrUnitario	money,
	@CodTipoEntrada	int,
	@Percentual		float,
	@DesFornecedor  varchar(10)
)
AS
	SET NOCOUNT ON
	
	IF Exists (SELECT * FROM tbl_Produtos WHERE codigounico = @CodProduto AND DesFornecedor = @DesFornecedor) BEGIN
	
		INSERT INTO tbl_Entrada(DocEntrada, DatEntrada, QtdProduto, VlrUnitario, CodTipoEntrada, codigounico, Percentual,DesFornecedor)
		VALUES (@DocEntrada, @DatEntrada, @QtdProduto, @VlrUnitario, @CodTipoEntrada, @CodProduto, @Percentual,@DesFornecedor)

		UPDATE tbl_Produtos
		SET	VlrUltPreco = VlrUnitario,
			QtdProduto = IsNull(QtdProduto, 0) + @QtdProduto, 
			VlrCusto = @VlrUnitario, 
			VlrPercent = @Percentual,
			VlrUnitario = @VlrUnitario * (@Percentual / 100)
		WHERE codigounico = @CodProduto
	END
	ELSE BEGIN
		INSERT INTO tbl_Produtos(CodProduto, DesProduto, DesLocal,VlrUnitario,QtdProduto,VlrCusto,VlrPercent,EstMinimo,
		DatCadastro, DesFornecedor, CodRefAntiga, DesFaz,VlrUltPreco,Imagem)
		SELECT CodProduto, DesProduto, DesLocal, @VlrUnitario * (@Percentual / 100),@QtdProduto,@VlrUnitario,@Percentual,EstMinimo,
		DatCadastro, @DesFornecedor, CodRefAntiga, DesFaz,VlrUltPreco,Imagem
		FROM tbl_Produtos 
		WHERE codigounico = @CodProduto
		
		SELECT TOP 1 @CodProduto = codigounico FROM tbl_Produtos ORDER BY codigounico DESC
		
		INSERT INTO tbl_Entrada(DocEntrada, DatEntrada, QtdProduto, VlrUnitario, CodTipoEntrada, codigounico, Percentual,DesFornecedor)
		VALUES (@DocEntrada, @DatEntrada, @QtdProduto, @VlrUnitario, @CodTipoEntrada, @CodProduto, @Percentual,@DesFornecedor)

	END
	
	SELECT Registros = @@RowCount
	RETURN
