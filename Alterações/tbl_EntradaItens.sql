USE [Loja]
GO

/****** Object:  Table [dbo].[tbl_EntradaItens]    Script Date: 03/11/2015 07:18:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_EntradaItens](
	[CodEntrada] [int] NOT NULL,
	[codigounico] [int] NOT NULL,
	[NumOrdem] [int] NULL,
	[CodProduto] [varchar](20) NULL,
	[DesProduto] [varchar](50) NULL,
	[NCM] [char](8) NULL,
	[Unidade] [varchar](15) NULL,
	[Quantidade] [decimal](18, 4) NULL,
	[VlrUnitario] [decimal](18, 4) NULL,
	[VlrFinal] [decimal](18, 4) NULL,
	[VlrBaseICMS] [decimal](18, 4) NULL,
	[VlrPercICMS] [decimal](18, 4) NULL,
	[VlrICMS] [decimal](18, 4) NULL,
	[VlrBaseICMSST] [decimal](18, 4) NULL,
	[VlrPercICMSST] [decimal](18, 4) NULL,
	[VlrICMSST] [decimal](18, 4) NULL,
	[VlrBasePIS] [decimal](18, 4) NULL,
	[VlrPercPIS] [decimal](18, 4) NULL,
	[VlrPIS] [decimal](18, 4) NULL,
	[VlrBaseCOFINS] [decimal](18, 4) NULL,
	[VlrPercCOFINS] [decimal](18, 4) NULL,
	[VlrCOFINS] [decimal](18, 4) NULL,
 CONSTRAINT [PK_tbl_EntradaItens] PRIMARY KEY CLUSTERED 
(
	[CodEntrada] ASC,
	[codigounico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_EntradaItens]  WITH CHECK ADD  CONSTRAINT [FK_tbl_EntradaItens_tbl_Entrada] FOREIGN KEY([CodEntrada])
REFERENCES [dbo].[tbl_Entrada] ([CodEntrada])
GO

ALTER TABLE [dbo].[tbl_EntradaItens] CHECK CONSTRAINT [FK_tbl_EntradaItens_tbl_Entrada]
GO


