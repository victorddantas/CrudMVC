USE [GTI]
GO

/****** Object:  StoredProcedure [dbo].[USP_L_PRODUTO]    Script Date: 16/08/2022 18:55:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[USP_L_PRODUTO]
AS
 
BEGIN
SELECT 
p.Id,
c.Descricao Categoria,
p.Nome,
p.Marca,
p.Fornecedor,
p.Peso

FROM Produto p
INNER JOIN CategoriaProduto c
on c.Id = p.CategoriaId
END
 
 

GO


