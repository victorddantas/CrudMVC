USE [GTI]
GO

/****** Object:  StoredProcedure [dbo].[USP_U_CLIENTE]    Script Date: 16/08/2022 22:08:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[USP_U_PRODUTO]
	@Id int,
   	@CategoriaId int,	
	@Nome NVARCHAR(50),
	@Marca NVARCHAR(50),
	@Fornecedor NVARCHAR(50),
	@Peso float

AS
BEGIN
UPDATE  Produto
		
SET		
		CategoriaId = @CategoriaId ,
		Nome = @Nome ,
		Marca = @Marca ,
		Fornecedor  = @Fornecedor,
		Peso  = @Peso
	

FROM Produto
WHERE Id = @Id
END

GO


