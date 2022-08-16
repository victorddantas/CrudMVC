USE [GTI]
GO

/****** Object:  StoredProcedure [dbo].[USP_L_CLIENTE]    Script Date: 16/08/2022 15:38:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[USP_L_PRODUTO]
AS
 
BEGIN
SELECT 
IDProduto,
IDProdutoCategoria,
Nome,
Marca,
Fornecedor,
Peso

FROM Produto
END
 
 

GO


