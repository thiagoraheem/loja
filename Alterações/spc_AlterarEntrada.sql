CREATE PROCEDURE spc_AlterarEntrada
	@DocEntrada		VARCHAR(15),
	@DatEntrada		SMALLDATETIME,
	@codigounico	INT,
	@Quantidade		FLOAT,
	@VlrUnitario	FLOAT

AS

	IF ISNULL(@Quantidade, 0) = 0 BEGIN
		DECLARE @QtdEntrada FLOAT
		
		SELECT @QtdEntrada = QtdProduto
		FROM tbl_Entrada
		WHERE DocEntrada = @DocEntrada AND DatEntrada = @DatEntrada AND codigounico = @codigounico
	
		UPDATE tbl_Produtos
		SET	QtdProduto = IsNull(QtdProduto, 0) - @QtdEntrada
		WHERE codigounico = @codigounico
	
		DELETE FROM tbl_Entrada WHERE DocEntrada = @DocEntrada AND DatEntrada = @DatEntrada AND codigounico = @codigounico
	END