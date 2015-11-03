USE [Loja]
GO

/****** Object:  View [dbo].[viw_ResumoDiario]    Script Date: 03/11/2015 07:17:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[viw_ResumoDiario]
AS

SELECT Data = ISNULL(CONVERT(CHAR(10), Data, 121), ''), ValorTotal = COALESCE( SUM(ValorTotal), 0)
FROM tbl_Saida
GROUP BY CONVERT(CHAR(10), Data, 121)



GO


