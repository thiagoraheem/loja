/****** Object:  StoredProcedure [dbo].[spc_AdicionarOrcamento]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_AdicionarOrcamento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spc_AdicionarOrcamento]
GO
/****** Object:  StoredProcedure [dbo].[spc_ApagarOrcamento]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_ApagarOrcamento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spc_ApagarOrcamento]
GO
/****** Object:  StoredProcedure [dbo].[spc_AtualizaEstoque]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_AtualizaEstoque]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spc_AtualizaEstoque]
GO
/****** Object:  StoredProcedure [dbo].[spc_DescontoVenda]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_DescontoVenda]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spc_DescontoVenda]
GO
/****** Object:  StoredProcedure [dbo].[spc_EstornaVenda]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_EstornaVenda]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spc_EstornaVenda]
GO
/****** Object:  StoredProcedure [dbo].[spc_FinalizaVenda]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_FinalizaVenda]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spc_FinalizaVenda]
GO
/****** Object:  StoredProcedure [dbo].[spc_PesqProduto]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_PesqProduto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spc_PesqProduto]
GO
/****** Object:  StoredProcedure [dbo].[spc_PesqSaida]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_PesqSaida]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spc_PesqSaida]
GO
/****** Object:  StoredProcedure [dbo].[spc_Reajuste]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_Reajuste]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spc_Reajuste]
GO
/****** Object:  View [dbo].[viw_Orcamento]    Script Date: 04/01/2013 21:56:50 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[viw_Orcamento]'))
DROP VIEW [dbo].[viw_Orcamento]
GO
/****** Object:  Table [dbo].[tbl_Entrada]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Entrada]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Entrada]
GO
/****** Object:  Table [dbo].[tbl_Orcamento]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Orcamento]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Orcamento]
GO
/****** Object:  Table [dbo].[tbl_Parametros]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Parametros]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Parametros]
GO
/****** Object:  Table [dbo].[tbl_Preco]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Preco]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Preco]
GO
/****** Object:  Table [dbo].[tbl_Produtos]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Produtos]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Produtos]
GO
/****** Object:  Table [dbo].[tbl_Saidas]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Saidas]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Saidas]
GO
/****** Object:  Table [dbo].[tbl_SaidasEstorno]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_SaidasEstorno]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_SaidasEstorno]
GO
/****** Object:  Table [dbo].[tbl_TipoEntrada]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_TipoEntrada]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_TipoEntrada]
GO
/****** Object:  Table [dbo].[tbl_TipoVenda]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_TipoVenda]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_TipoVenda]
GO
/****** Object:  Table [dbo].[tbl_Usuario]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Usuario]') AND type in (N'U'))
DROP TABLE [dbo].[tbl_Usuario]
GO
/****** Object:  Default [DF_tbl_Orcamento_FlgStatus]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tbl_Orcamento_FlgStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Orcamento]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_Orcamento_FlgStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_Orcamento] DROP CONSTRAINT [DF_tbl_Orcamento_FlgStatus]
END


End
GO
/****** Object:  Default [DF_tbl_Orcamento_DatOrca]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tbl_Orcamento_DatOrca]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Orcamento]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_Orcamento_DatOrca]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_Orcamento] DROP CONSTRAINT [DF_tbl_Orcamento_DatOrca]
END


End
GO
/****** Object:  Default [DF_tbl_TipoVenda_flgAtivo]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tbl_TipoVenda_flgAtivo]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_TipoVenda]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_TipoVenda_flgAtivo]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_TipoVenda] DROP CONSTRAINT [DF_tbl_TipoVenda_flgAtivo]
END


End
GO
/****** Object:  Default [DF_tbl_TipoVenda_flgGeraAPagar]    Script Date: 04/01/2013 21:56:49 ******/
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tbl_TipoVenda_flgGeraAPagar]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_TipoVenda]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_TipoVenda_flgGeraAPagar]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_TipoVenda] DROP CONSTRAINT [DF_tbl_TipoVenda_flgGeraAPagar]
END


End
GO
/****** Object:  Table [dbo].[tbl_Usuario]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Usuario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Usuario](
	[CODIGO] [varchar](3) COLLATE Latin1_General_CI_AS NULL,
	[NOME] [varchar](10) COLLATE Latin1_General_CI_AS NULL,
	[TSENHA] [varchar](6) COLLATE Latin1_General_CI_AS NULL,
	[STATUS] [varchar](10) COLLATE Latin1_General_CI_AS NULL,
	[NIVEL] [varchar](1) COLLATE Latin1_General_CI_AS NULL
)
END
GO
/****** Object:  Table [dbo].[tbl_TipoVenda]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_TipoVenda]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_TipoVenda](
	[CodTipoVenda] [int] IDENTITY(1,1) NOT NULL,
	[DesTipoVenda] [varchar](50) COLLATE Latin1_General_CI_AS NULL,
	[flgAtivo] [bit] NULL,
	[flgAVista] [bit] NULL,
	[QtdDias] [numeric](10, 0) NULL,
 CONSTRAINT [PK_tbl_TipoVenda] PRIMARY KEY CLUSTERED 
(
	[CodTipoVenda] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[tbl_TipoEntrada]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_TipoEntrada]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_TipoEntrada](
	[CodTipoEntrada] [int] IDENTITY(1,1) NOT NULL,
	[DesTipoEntrada] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[flgMovimentaEstoque] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_TipoEntrada] PRIMARY KEY CLUSTERED 
(
	[CodTipoEntrada] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[tbl_SaidasEstorno]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_SaidasEstorno]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_SaidasEstorno](
	[CodVenda] [int] NOT NULL,
	[DatSaida] [smalldatetime] NOT NULL,
	[CodOrcamento] [varchar](5) COLLATE Latin1_General_CI_AS NOT NULL,
	[CodProduto] [varchar](20) COLLATE Latin1_General_CI_AS NOT NULL,
	[DesProduto] [varchar](30) COLLATE Latin1_General_CI_AS NOT NULL,
	[VlrUnitario] [money] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[VlrCusto] [money] NOT NULL,
	[VlrFinal]  AS ([Quantidade]*[VlrUnitario]),
	[CodTipoVenda] [int] NOT NULL,
	[DatEstorno] [smalldatetime] NOT NULL,
	[MotivoEstorno] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
 CONSTRAINT [PK_tbl_SaidasEstorno] PRIMARY KEY CLUSTERED 
(
	[CodVenda] ASC,
	[DatSaida] ASC,
	[CodProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[tbl_Saidas]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Saidas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Saidas](
	[CodVenda] [int] IDENTITY(1,1) NOT NULL,
	[DatSaida] [smalldatetime] NOT NULL,
	[CodOrcamento] [varchar](5) COLLATE Latin1_General_CI_AS NOT NULL,
	[CodProduto] [varchar](20) COLLATE Latin1_General_CI_AS NOT NULL,
	[DesProduto] [varchar](30) COLLATE Latin1_General_CI_AS NOT NULL,
	[VlrUnitario] [money] NOT NULL,
	[Quantidade] [int] NOT NULL,
	[VlrCusto] [money] NOT NULL,
	[VlrFinal]  AS ([Quantidade]*[VlrUnitario]),
	[CodTipoVenda] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Saidas_1] PRIMARY KEY CLUSTERED 
(
	[CodVenda] ASC,
	[DatSaida] ASC,
	[CodProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[tbl_Produtos]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Produtos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Produtos](
	[CodProduto] [varchar](20) COLLATE Latin1_General_CI_AS NOT NULL,
	[DesProduto] [varchar](30) COLLATE Latin1_General_CI_AS NOT NULL,
	[DesLocal] [varchar](4) COLLATE Latin1_General_CI_AS NOT NULL,
	[VlrUnitario] [money] NOT NULL,
	[QtdProduto] [numeric](9, 0) NOT NULL,
	[VlrCusto] [money] NOT NULL,
	[VlrPercent] [numeric](8, 2) NOT NULL,
	[EstMinimo] [numeric](9, 0) NULL,
	[DatCadastro] [smalldatetime] NOT NULL,
	[DesFornecedor] [varchar](10) COLLATE Latin1_General_CI_AS NULL,
	[CodRefAntiga] [varchar](10) COLLATE Latin1_General_CI_AS NULL,
	[DesFaz] [float] NULL,
	[VlrUltPreco] [float] NULL,
	[Imagem] [image] NULL,
 CONSTRAINT [PK_tbl_Produtos] PRIMARY KEY CLUSTERED 
(
	[CodProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[tbl_Preco]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Preco]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Preco](
	[CodProduto] [varchar](20) COLLATE Latin1_General_CI_AS NULL,
	[VlrProduto] [float] NULL
)
END
GO
/****** Object:  Table [dbo].[tbl_Parametros]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Parametros]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Parametros](
	[EmpresaNome] [varchar](50) COLLATE Latin1_General_CI_AS NOT NULL,
	[EmpresaEndereco] [varchar](50) COLLATE Latin1_General_CI_AS NULL,
	[EmpresaTelefone] [varchar](15) COLLATE Latin1_General_CI_AS NULL,
	[EmpresaEmail] [varchar](25) COLLATE Latin1_General_CI_AS NULL,
	[EmpresaWebSite] [varchar](30) COLLATE Latin1_General_CI_AS NULL,
	[EmpresaSlogan] [varchar](50) COLLATE Latin1_General_CI_AS NULL,
	[EmpresaLogotipo] [image] NULL,
	[EmpresaCNPJ] [char](18) COLLATE Latin1_General_CI_AS NULL,
	[EmpresaInscEstadual] [varchar](15) COLLATE Latin1_General_CI_AS NULL,
	[SisCodVenda] [int] NULL,
 CONSTRAINT [PK_tbl_Parametros] PRIMARY KEY CLUSTERED 
(
	[EmpresaNome] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[tbl_Orcamento]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Orcamento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Orcamento](
	[CodOrca] [varchar](5) COLLATE Latin1_General_CI_AS NOT NULL,
	[CodProduto] [varchar](20) COLLATE Latin1_General_CI_AS NOT NULL,
	[DescProduto] [varchar](30) COLLATE Latin1_General_CI_AS NULL,
	[Quantidade] [float] NULL,
	[VlrUnitario] [money] NOT NULL,
	[VlrCusto] [money] NOT NULL,
	[DesLocal] [varchar](4) COLLATE Latin1_General_CI_AS NULL,
	[PF]  AS ([VlrUnitario]*[Quantidade]),
	[FlgStatus] [char](1) COLLATE Latin1_General_CI_AS NULL,
	[DatOrca] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_tbl_Orcamento] PRIMARY KEY CLUSTERED 
(
	[CodOrca] ASC,
	[CodProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[tbl_Entrada]    Script Date: 04/01/2013 21:56:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tbl_Entrada]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tbl_Entrada](
	[DocEntrada] [varchar](15) COLLATE Latin1_General_CI_AS NOT NULL,
	[DatEntrada] [smalldatetime] NOT NULL,
	[CodProduto] [varchar](20) COLLATE Latin1_General_CI_AS NOT NULL,
	[DesProduto] [varchar](30) COLLATE Latin1_General_CI_AS NOT NULL,
	[QtdProduto] [numeric](18, 0) NOT NULL,
	[VlrUnitario] [numeric](18, 2) NOT NULL,
	[VlrTotal] [numeric](18, 2) NOT NULL,
	[CodTipoEntrada] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Entrada] PRIMARY KEY CLUSTERED 
(
	[DocEntrada] ASC,
	[DatEntrada] ASC,
	[CodProduto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  View [dbo].[viw_Orcamento]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[viw_Orcamento]'))
EXEC dbo.sp_executesql @statement = N'CREATE VIEW [dbo].[viw_Orcamento]
AS
SELECT        CodOrca, COUNT(Quantidade) AS Itens, SUM(VlrUnitario * Quantidade) AS VlrTotal, FlgStatus
FROM            dbo.tbl_Orcamento
GROUP BY CodOrca, FlgStatus
'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPane1' , N'SCHEMA',N'dbo', N'VIEW',N'viw_Orcamento', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[24] 2[8] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tbl_Orcamento"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 290
               Right = 235
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1470
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viw_Orcamento'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_DiagramPaneCount' , N'SCHEMA',N'dbo', N'VIEW',N'viw_Orcamento', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'viw_Orcamento'
GO
/****** Object:  StoredProcedure [dbo].[spc_Reajuste]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_Reajuste]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spc_Reajuste]
	(
		@Porcentagem numeric(8,2),
		@DesFornecedor varchar(10) = NULL
	)

AS
	SET NOCOUNT ON
	
	IF @DesFornecedor = '''' SET @DesFornecedor = NULL
	
	UPDATE tbl_Produtos
	SET Desfaz = VlrPercent,
		VlrUltPreco = VlrUnitario,
		VlrUnitario = VlrUnitario + ((@Porcentagem * VlrUnitario) / 100)
	WHERE IsNull(DesFornecedor, '''') = IsNull(@DesFornecedor, IsNull(DesFornecedor, ''''))
			AND VlrUnitario > 0
	
	UPDATE tbl_Produtos
	SET VlrPercent = CAST(((VlrUnitario / VlrCusto) * 100) - 100 AS Numeric(8,2))
	WHERE VlrCusto > 0 AND VlrUnitario > 0
	
	SELECT Registros = @@RowCount' 
END
GO
/****** Object:  StoredProcedure [dbo].[spc_PesqSaida]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_PesqSaida]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spc_PesqSaida]
(
	@DatInicial smalldatetime,
	@DatFinal smalldatetime,
	@CodProduto varchar(20)
)
AS
SET NOCOUNT ON;

If @CodProduto = '''' SET @CodProduto = NULL

SELECT CodVenda, CodOrcamento, CodProduto, DesProduto, VlrUnitario, Quantidade, VlrCusto, VlrFinal, DatSaida,
A.CodTipoVenda, DesTipoVenda
FROM tbl_Saidas A
INNER JOIN tbl_TipoVenda B ON B.CodTipoVenda = A.CodTipoVenda
WHERE (DatSaida >= @DatInicial AND
		DatSaida <= @DatFinal+1) AND
		CodProduto = IsNull(@CodProduto, CodProduto)' 
END
GO
/****** Object:  StoredProcedure [dbo].[spc_PesqProduto]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_PesqProduto2]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spc_PesqProduto2]
	(
	@CodProduto varchar(20),
	@DesProduto varchar(50),
	@Local		varchar(4),
	@flgSaldo	char(1)
	)
AS
	/* SET NOCOUNT ON */ 
	-- Trabalha as variáveis
	IF @CodProduto = '''' SET @CodProduto = NULL
	IF @DesProduto = '''' SET @DesProduto = NULL
	IF @Local = '''' SET @Local = NULL
	
	CREATE TABLE #tmpProdutos(
		[CodProduto] [varchar](20) NOT NULL,
		[DesProduto] [varchar](30) NOT NULL,
		[DesLocal] [varchar](4) NOT NULL,
		[VlrUnitario] [float] NULL,
		[QtdProduto] [float] NULL,
		[VlrCusto] [float] NULL,
		[VlrPercent] [float] NULL,
		[EstMinimo] [float] NULL,
		[DatCadastro] [varchar](10) NULL,
		[DesFornecedor] [varchar](10) NULL,
		[CodRefAntiga] [varchar](10) NULL,
		[DesFaz] [float] NULL,
		[VlrUltPreco] [float] NULL,
		[Imagem] [image] NULL,
	)

	INSERT INTO #tmpProdutos
	SELECT *
	FROM tbl_Produtos
	
	-- @flgSaldo = "S" apaga todos os produtos com quantidade igual ou menor que zero
	-- @flgSaldo = "N" apaga todos os produtos com quantidade igual ou maior que zero
	-- @flgSaldo = "T" mostra tudo
	IF @flgSaldo <> '''' AND @flgSaldo = ''S'' BEGIN
		DELETE FROM #tmpProdutos WHERE QtdProduto <= 0
	END
	ELSE IF @flgSaldo <> '''' AND @flgSaldo = ''N'' BEGIN
		DELETE FROM #tmpProdutos WHERE QtdProduto > 0
	END
	
	SELECT CodProduto, DesProduto, DesLocal, VlrUnitario, QtdProduto, VlrCusto, VlrPercent, 
			EstMinimo, DatCadastro, DesFornecedor, CodRefAntiga, DesFaz, VlrUltPreco, Imagem
	FROM #tmpProdutos
	WHERE DesProduto LIKE ''%'' + IsNull(@DesProduto,	DesProduto) + ''%'' AND 
			CodProduto LIKE ''%'' + IsNull(@CodProduto, CodProduto) + ''%'' AND 
			DesLocal LIKE ''%'' + IsNull(@Local, DesLocal) + ''%''
	
	/*
	IF IsNull(@CodProduto, '''') <> '''' AND IsNull(@DesProduto, '''') = '''' AND IsNull(@Local, '''') = '''' BEGIN
		SELECT CodProduto, DesProduto, DesLocal, VlrUnitario, QtdProduto, VlrCusto, VlrPercent, 
				EstMinimo, DatCadastro, DesFornecedor, CodRefAntiga, DesFaz, VlrUltPreco, Imagem
		FROM dbo.tbl_Produtos
		WHERE CodProduto LIKE ''%'' + @CodProduto + ''%''
	END
	ELSE IF IsNull(@CodProduto, '''') = '''' AND IsNull(@DesProduto, '''') <> '''' AND IsNull(@Local, '''') = '''' BEGIN
		SELECT CodProduto, DesProduto, DesLocal, VlrUnitario, QtdProduto, VlrCusto, VlrPercent, 
				EstMinimo, DatCadastro, DesFornecedor, CodRefAntiga, DesFaz, VlrUltPreco, Imagem
		FROM dbo.tbl_Produtos
		WHERE DesProduto LIKE ''%'' + @DesProduto + ''%''
	END 
	ELSE IF IsNull(@CodProduto, '''') = '''' AND IsNull(@DesProduto, '''') = '''' AND IsNull(@Local, '''') <> '''' BEGIN
		SELECT CodProduto, DesProduto, DesLocal, VlrUnitario, QtdProduto, VlrCusto, VlrPercent, 
				EstMinimo, DatCadastro, DesFornecedor, CodRefAntiga, DesFaz, VlrUltPreco, Imagem
		FROM dbo.tbl_Produtos
		WHERE DesLocal = @Local
	END
	ELSE IF IsNull(@CodProduto, '''') = '''' AND IsNull(@DesProduto, '''') = '''' AND IsNull(@Local, '''') = '''' BEGIN
		SELECT CodProduto, DesProduto, DesLocal, VlrUnitario, QtdProduto, VlrCusto, VlrPercent, 
				EstMinimo, DatCadastro, DesFornecedor, CodRefAntiga, DesFaz, VlrUltPreco, Imagem
		FROM dbo.tbl_Produtos
	END
	ELSE BEGIN
	SELECT CodProduto, DesProduto, DesLocal, VlrUnitario, QtdProduto, VlrCusto, VlrPercent, 
			EstMinimo, DatCadastro, DesFornecedor, CodRefAntiga, DesFaz, VlrUltPreco, Imagem
	FROM dbo.tbl_Produtos
	WHERE DesProduto LIKE ''%'' + IsNull(@DesProduto, '''') + ''%'' AND 
			CodProduto LIKE ''%'' + IsNull(@CodProduto, '''') + ''%'' AND 
			DesLocal LIKE ''%'' + IsNull(@Local, DesLocal) + ''%''
	END
	*/
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spc_FinalizaVenda]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_FinalizaVenda]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spc_FinalizaVenda]
	(
	@CodOrca varchar(5),
	@CodTipoVenda int,
	@flgApagaOrca char(1) = ''N''
	)
AS
	SET NOCOUNT ON
	
	DECLARE @CodVenda as int
	
	UPDATE tbl_Parametros SET @CodVenda = SisCodVenda = SisCodVenda + 1
	
	INSERT INTO tbl_Saidas (CodVenda, CodOrcamento, CodProduto, DesProduto, VlrUnitario,
							Quantidade, VlrCusto, DatSaida, CodTipoVenda)
	SELECT @CodVenda, CodOrca, CodProduto, DescProduto, VlrUnitario, Quantidade, VlrCusto, GetDate(), @CodTipoVenda
	FROM tbl_Orcamento
	WHERE CodOrca = @CodOrca
	
	UPDATE tbl_Produtos
	SET QtdProduto = QtdProduto - Quantidade
	FROM tbl_Produtos
	INNER JOIN tbl_Orcamento ON
		tbl_Orcamento.CodProduto = tbl_Produtos.CodProduto
	WHERE CodOrca = @CodOrca
	
	IF @flgApagaOrca = ''N''
		UPDATE tbl_Orcamento
		SET flgStatus = ''V''
		WHERE CodOrca = @CodOrca
	ELSE
		DELETE FROM tbl_Orcamento
		WHERE CodOrca = @CodOrca
	
	SELECT Resultado = @@RowCount
	
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spc_EstornaVenda]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_EstornaVenda]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spc_EstornaVenda]
	(
	@CodVenda int,
	@CodProduto varchar(20),
	@DesMotivo varchar(100)
	)
AS
	SET NOCOUNT ON
	
	IF @CodProduto = '''' SET @CodProduto = NULL
	
	UPDATE tbl_Produtos
	SET QtdProduto = QtdProduto - Quantidade
	FROM tbl_Produtos
	INNER JOIN tbl_Saidas ON
		tbl_Saidas.CodProduto = tbl_Produtos.CodProduto
	WHERE CodVenda = @CodVenda
	
	INSERT INTO tbl_SaidasEstorno (CodVenda, DatSaida, CodOrcamento, CodProduto, DesProduto,
									VlrUnitario, Quantidade, VlrCusto, CodTipoVenda,
									DatEstorno, MotivoEstorno)
	SELECT CodVenda, DatSaida, CodOrcamento, CodProduto, DesProduto, VlrUnitario, 
			Quantidade, VlrCusto, CodTipoVenda, GetDate(), @DesMotivo
	FROM tbl_Saidas
	WHERE CodVenda = @CodVenda AND
			CodProduto = IsNull(@CodProduto, CodProduto)
	
	DELETE FROM tbl_Saidas
	WHERE CodVenda = @CodVenda AND
			CodProduto = IsNull(@CodProduto, CodProduto)
	
	
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spc_DescontoVenda]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_DescontoVenda]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spc_DescontoVenda]
(
	@CodOrca varchar(5),
	@Desconto numeric(6,4),
	@flgTipoDesconto char(1)
)
AS
	SET NOCOUNT ON;

if @flgTipoDesconto = ''P'' begin

	SET @Desconto = @Desconto / 100

end
else begin
	declare @ValorTotal money
	
	select @ValorTotal = sum(PF) FROM tbl_Orcamento Where CodOrca = @CodOrca
	
	select @Desconto = 1 - ((@ValorTotal - @Desconto) / @ValorTotal)
	
end

	UPDATE tbl_Orcamento
	SET VlrUnitario = VlrUnitario - (VlrUnitario * @Desconto)
	WHERE (CodOrca = @CodOrca);
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spc_AtualizaEstoque]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_AtualizaEstoque]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spc_AtualizaEstoque]
	(
	@CodProduto varchar(20),
	@DesProduto varchar(30),
	@DesLocal varchar(4),
	@VlrUnitario money,
	@QtdProduto float,
	@VlrCusto money,
	@VlrPercent numeric(6, 2),
	@EstMinimo numeric(9,0),
	@DesFornecedor varchar(10),
	@CodRefAntiga varchar(10),
	@Imagem image,
	@CodTipoEntrada	int
	)
AS
	SET NOCOUNT ON
	
	IF EXISTS (SELECT CodProduto FROM tbl_Produtos WHERE CodProduto = @CodProduto) BEGIN
	
		IF (SELECT flgMovimentaEstoque FROM tbl_TipoEntrada WHERE CodTipoEntrada = @CodTipoEntrada) = ''True''
		BEGIN
			UPDATE tbl_Produtos
			SET QtdProduto = IsNull(QtdProduto, 0) + @QtdProduto
			WHERE CodProduto = @CodProduto
		END
	END
	ELSE BEGIN
		INSERT INTO tbl_Produtos (CodProduto, DesProduto, DesLocal, VlrUnitario, QtdProduto,
									VlrCusto, VlrPercent, EstMinimo, DatCadastro, DesFornecedor,
									CodRefAntiga/*, Imagem*/)
		VALUES (@CodProduto, @DesProduto, @DesLocal, @VlrUnitario, @QtdProduto, @VlrCusto, 
				@VlrPercent, @EstMinimo, GetDate(), @DesFornecedor, @CodRefAntiga/*, @Imagem*/)
	END
	
	SELECT Registros = @@RowCount
	RETURN
' 
END
GO
/****** Object:  StoredProcedure [dbo].[spc_ApagarOrcamento]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_ApagarOrcamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spc_ApagarOrcamento]
(
	@Original_CodOrca varchar(5)
)
AS
	SET NOCOUNT OFF;
DELETE FROM tbl_Orcamento
WHERE        (CodOrca = @Original_CodOrca)' 
END
GO
/****** Object:  StoredProcedure [dbo].[spc_AdicionarOrcamento]    Script Date: 04/01/2013 21:56:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spc_AdicionarOrcamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[spc_AdicionarOrcamento]
(
	@Retorno varchar(5) OUTPUT,
	@CodOrca varchar(5),
	@CodProduto varchar(20)
)
AS
	SET NOCOUNT ON
	
	DECLARE @Orcamento varchar(5)
	
	IF IsNull(@CodOrca, '''') <> '''' BEGIN
		SET @Orcamento = @CodOrca
	END
	ELSE BEGIN
		SELECT @Orcamento = MAX(CodOrca) FROM tbl_Orcamento
		IF IsNull(@Orcamento, '''') = '''' SET @Orcamento = ''00000''
		SET @Orcamento = Right(''00000'' + Cast((@Orcamento + 1) as varchar), 5)
	END
	
	IF NOT EXISTS (SELECT CodOrca FROM tbl_Orcamento WHERE CodOrca = @Orcamento AND CodProduto = @CodProduto) BEGIN
		INSERT INTO tbl_Orcamento (CodOrca, CodProduto, DescProduto, Quantidade, VlrUnitario, VlrCusto, DesLocal, FlgStatus)
		SELECT @Orcamento, CodProduto, DesProduto, 1, VlrUnitario, VlrCusto, DesLocal, ''O''
		FROM tbl_Produtos
		WHERE CodProduto = @CodProduto
	END
	ELSE
	BEGIN
			UPDATE tbl_Orcamento
			SET Quantidade = Quantidade + 1
			WHERE CodOrca = @Orcamento AND
					CodProduto = @CodProduto
	END
	
	SELECT @Retorno = @Orcamento
	
	RETURN
' 
END
GO
/****** Object:  Default [DF_tbl_Orcamento_FlgStatus]    Script Date: 04/01/2013 21:56:49 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tbl_Orcamento_FlgStatus]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Orcamento]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_Orcamento_FlgStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_Orcamento] ADD  CONSTRAINT [DF_tbl_Orcamento_FlgStatus]  DEFAULT ('O') FOR [FlgStatus]
END


End
GO
/****** Object:  Default [DF_tbl_Orcamento_DatOrca]    Script Date: 04/01/2013 21:56:49 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tbl_Orcamento_DatOrca]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_Orcamento]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_Orcamento_DatOrca]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_Orcamento] ADD  CONSTRAINT [DF_tbl_Orcamento_DatOrca]  DEFAULT (getdate()) FOR [DatOrca]
END


End
GO
/****** Object:  Default [DF_tbl_TipoVenda_flgAtivo]    Script Date: 04/01/2013 21:56:49 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tbl_TipoVenda_flgAtivo]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_TipoVenda]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_TipoVenda_flgAtivo]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_TipoVenda] ADD  CONSTRAINT [DF_tbl_TipoVenda_flgAtivo]  DEFAULT ('S') FOR [flgAtivo]
END


End
GO
/****** Object:  Default [DF_tbl_TipoVenda_flgGeraAPagar]    Script Date: 04/01/2013 21:56:49 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF_tbl_TipoVenda_flgGeraAPagar]') AND parent_object_id = OBJECT_ID(N'[dbo].[tbl_TipoVenda]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_tbl_TipoVenda_flgGeraAPagar]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tbl_TipoVenda] ADD  CONSTRAINT [DF_tbl_TipoVenda_flgGeraAPagar]  DEFAULT ('N') FOR [flgAVista]
END


End
GO
