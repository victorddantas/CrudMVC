USE [GTI]
GO

/****** Object:  StoredProcedure [dbo].[USP_O_CLIENTE]    Script Date: 16/08/2022 22:16:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[USP_O_PRODUTO]
  @Id INT
AS
BEGIN
SELECT 
Id,
CategoriaId,
Nome,
Marca,
Fornecedor,
Peso
									            
FROM Produto
WHERE Id = @Id
END

GO


