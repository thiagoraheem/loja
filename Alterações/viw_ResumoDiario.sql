USE [Loja]
GO

/****** Object:  View [dbo].[viw_ResumoDiario]    Script Date: 03/11/2015 13:01:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[viw_ResumoDiario]
AS

SELECT Data = ISNULL(CONVERT(CHAR(10), Data, 103), ''), ValorTotal = COALESCE( SUM(ValorTotal), 0), Mes = CONVERT(CHAR(7), Data, 121)
FROM tbl_Saida
GROUP BY CONVERT(CHAR(10), Data, 103), CONVERT(CHAR(7), Data, 121)



GO


