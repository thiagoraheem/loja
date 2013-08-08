USE [Loja]
GO
/****** Object:  StoredProcedure [dbo].[spc_DescontoVenda]    Script Date: 06/01/2013 16:08:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spc_DescontoVenda]
(
	@CodOrca varchar(5),
	@Desconto numeric(10,4)
)
AS
	SET NOCOUNT ON;


	UPDATE tbl_Orcamento
	SET VlrUnitario = ROUND(VlrCusto * (@Desconto/100), 2)
	WHERE (CodOrca = @CodOrca);