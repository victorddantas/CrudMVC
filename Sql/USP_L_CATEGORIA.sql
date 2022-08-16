USE [GTI]
GO

/****** Object:  StoredProcedure [dbo].[USP_L_PRODUTO]    Script Date: 16/08/2022 20:02:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[USP_L_CATEGORIA]
AS
 
BEGIN
SELECT 
c.Id,
c.Descricao

FROM CategoriaProduto c

END
 
 

GO


