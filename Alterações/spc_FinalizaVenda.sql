USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spc_FinalizaVenda]    Script Date: 27/09/2015 01:20:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spc_FinalizaVenda]
	(
	@CodOrca		VARCHAR(5),
	@CodTipoVenda	INT,
	@flgApagarOrca	CHAR(1) = 'S'
	)
AS
	SET NOCOUNT ON
	
	BEGIN TRANSACTION

	BEGIN TRY 
		DECLARE @CodVenda int

		INSERT INTO tbl_Saidas(Data, ValorTotal, QtdItens, FlgStatusNFE, ChaveSefaz, FlgStatusNota, CodTipoVenda)
		SELECT GETDATE(), SUM(VlrUnitario * Quantidade), SUM(Quantidade), '', '', '', @CodTipoVenda
		FROM tbl_Orcamento
		WHERE CodOrca = @CodOrca

		SELECT @CodVenda = @@IDENTITY

		INSERT INTO tbl_SaidasItens (CodVenda, CodOrcamento, CodProduto, DesProduto, VlrUnitario,
								Quantidade, VlrCusto, DatSaida, CodTipoVenda, codigounico)
		SELECT @CodVenda, CodOrca, CodProduto, DescProduto, VlrUnitario, Quantidade, VlrCusto, GetDate(), @CodTipoVenda, codigounico
		FROM tbl_Orcamento
		WHERE CodOrca = @CodOrca

		UPDATE tbl_Produtos
		SET QtdProduto = QtdProduto - Quantidade
		FROM tbl_Produtos
		INNER JOIN tbl_Orcamento ON
			tbl_Orcamento.codigounico = tbl_Produtos.codigounico
		WHERE CodOrca = @CodOrca

		IF @flgApagarOrca = 'N'
			UPDATE tbl_Orcamento
			SET flgStatus = 'V'
			WHERE CodOrca = @CodOrca
		ELSE
			DELETE FROM tbl_Orcamento 
			WHERE CodOrca = @CodOrca
		
		COMMIT
	END TRY
	BEGIN CATCH
		DECLARE @Mensagem VARCHAR(1000)
		SET @Mensagem = ERROR_MESSAGE()
		RAISERROR (@Mensagem, 16, 0)
		ROLLBACK
	END CATCH
	
	SELECT Resultado = @@RowCount

