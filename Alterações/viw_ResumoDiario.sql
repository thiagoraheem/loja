USE [Loja]
GO

/****** Object:  View [dbo].[viw_ResumoDiario]    Script Date: 04/11/2015 17:35:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER VIEW [dbo].[viw_ResumoDiario]
AS

SELECT Data = ISNULL(CONVERT(SMALLDATETIME, CONVERT(CHAR(10), Data, 121), 121), ''), ValorTotal = COALESCE( SUM(ValorTotal), 0), Mes = CONVERT(CHAR(7), Data, 121)
FROM tbl_Saida
WHERE CodVenda NOT LIKE 'V%'
GROUP BY  ISNULL(CONVERT(SMALLDATETIME, CONVERT(CHAR(10), Data, 121), 121), ''), CONVERT(CHAR(7), Data, 121)





GO


