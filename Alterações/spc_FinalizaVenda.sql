USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spc_FinalizaVenda]    Script Date: 18/10/2015 22:04:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spc_FinalizaVenda]
	(
	@CodOrca		VARCHAR(5),
	@CodTipoVenda	INT,
	@CodCliente		INT = NULL
	)
AS
	SET NOCOUNT ON
	
	BEGIN TRANSACTION

	BEGIN TRY 
		DECLARE @CodVenda int

		SELECT @CodVenda = SisCodVenda + 1
		FROM tbl_Parametros


		INSERT INTO tbl_Saida(CodVenda, Data, ValorTotal, QtdItens, FlgStatusNFE, ChaveSefaz, FlgStatusNota, CodTipoVenda, CodCliente)
		SELECT @CodVenda, GETDATE(), SUM(VlrUnitario * Quantidade), SUM(Quantidade), '', '', '', @CodTipoVenda, @CodCliente
		FROM tbl_Orcamento
		WHERE CodOrca = @CodOrca

		--SELECT @CodVenda = @@IDENTITY

		INSERT INTO tbl_SaidaItens (CodVenda, CodOrcamento, CodProduto, DesProduto, VlrUnitario,
								Quantidade, VlrCusto, DatSaida, codigounico)
		SELECT @CodVenda, CodOrca, CodProduto, DescProduto, VlrUnitario, Quantidade, VlrCusto, GetDate(), codigounico
		FROM tbl_Orcamento
		WHERE CodOrca = @CodOrca

		UPDATE tbl_Produtos
		SET QtdProduto = QtdProduto - Quantidade
		FROM tbl_Produtos
		INNER JOIN tbl_Orcamento ON
			tbl_Orcamento.codigounico = tbl_Produtos.codigounico
		WHERE CodOrca = @CodOrca
		
		UPDATE tbl_Parametros SET SisCodVenda = @CodVenda

		COMMIT
	END TRY
	BEGIN CATCH
		DECLARE @Mensagem VARCHAR(1000)
		SET @Mensagem = ERROR_MESSAGE()
		RAISERROR (@Mensagem, 16, 0)
		ROLLBACK
	END CATCH
	
	SELECT Resultado = @CodVenda

