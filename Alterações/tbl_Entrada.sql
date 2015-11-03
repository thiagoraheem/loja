USE [Loja]
GO

/****** Object:  Table [dbo].[tbl_Entrada]    Script Date: 03/11/2015 07:18:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[tbl_Entrada](
	[CodEntrada] [int] IDENTITY(1,1) NOT NULL,
	[DocEntrada] [varchar](20) NOT NULL,
	[SerieNota] [varchar](5) NULL,
	[DatEmissao] [datetime] NULL,
	[DatEntrada] [smalldatetime] NOT NULL,
	[CodTipoEntrada] [int] NOT NULL,
	[CNPJ] [char](14) NULL,
	[CPF] [char](12) NULL,
	[Nome] [varchar](30) NULL,
 CONSTRAINT [PK_tbl_Entrada] PRIMARY KEY CLUSTERED 
(
	[CodEntrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[tbl_Entrada]  WITH CHECK ADD  CONSTRAINT [FK_tbl_Entrada_tbl_TipoEntrada] FOREIGN KEY([CodTipoEntrada])
REFERENCES [dbo].[tbl_TipoEntrada] ([CodTipoEntrada])
GO

ALTER TABLE [dbo].[tbl_Entrada] CHECK CONSTRAINT [FK_tbl_Entrada_tbl_TipoEntrada]
GO


