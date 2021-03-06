USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spc_AdicionarEntrada]    Script Date: 05/17/2013 17:30:44 ******/
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
	@DesFornecedor  varchar(20)
)
AS
	SET NOCOUNT ON
	
	INSERT INTO tbl_Entrada(DocEntrada, DatEntrada, QtdProduto, VlrUnitario, CodTipoEntrada, codigounico, Percentual,DesFornecedor)
	VALUES (@DocEntrada, @DatEntrada, @QtdProduto, @VlrUnitario, @CodTipoEntrada, @CodProduto, @Percentual,@DesFornecedor)

	IF Exists (SELECT * FROM tbl_Produtos WHERE codigounico = @CodProduto AND DesFornecedor = @DesFornecedor)
	
		UPDATE tbl_Produtos
		SET	VlrUltPreco = VlrUnitario,
			QtdProduto = IsNull(QtdProduto, 0) + @QtdProduto, 
			VlrCusto = @VlrUnitario, 
			VlrPercent = @Percentual,
			VlrUnitario = @VlrUnitario * ((@Percentual / 100) + 1)
		WHERE codigounico = @CodProduto
	ELSE 
		INSERT INTO tbl_Produtos(CodProduto, DesProduto, DesLocal,VlrUnitario,QtdProduto,VlrCusto,VlrPercent,EstMinimo,
		DatCadastro, DesFornecedor, CodRefAntiga, DesFaz,VlrUltPreco,Imagem,codigounico)
		SELECT CodProduto, DesProduto, DesLocal,@VlrUnitario * (1+(@Percentual / 100)),@QtdProduto,@VlrUnitario,@Percentual,EstMinimo,
		DatCadastro, @DesFornecedor, CodRefAntiga, DesFaz,VlrUltPreco,Imagem,codigounico 
		FROM tbl_Produtos 
		WHERE codigounico = @CodProduto
						  	
	
	SELECT Registros = @@RowCount
	RETURN
