USE [GTI]
GO

/****** Object:  Table [dbo].[Produto]    Script Date: 16/08/2022 18:53:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Produto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoriaId] [int] NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[Fornecedor] [nvarchar](50) NOT NULL,
	[Peso] [float] NOT NULL,
 CONSTRAINT [PK_Produtos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produtos_CategoriaProduto] FOREIGN KEY([CategoriaId])
REFERENCES [dbo].[CategoriaProduto] ([Id])
GO

ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produtos_CategoriaProduto]
GO


