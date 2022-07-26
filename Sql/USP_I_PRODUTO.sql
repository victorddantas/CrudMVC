USE [GTI]
GO
/****** Object:  StoredProcedure [dbo].[USP_I_PRODUTO]    Script Date: 16/08/2022 20:59:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[USP_I_PRODUTO]
	@CategoriaId int,	
	@Nome NVARCHAR(50),
	@Marca NVARCHAR(50),
	@Fornecedor NVARCHAR(50),
	@Peso float
	 
AS
BEGIN


	INSERT INTO Produto
			( 
			CategoriaId,
			Nome ,
			Marca ,
			Fornecedor ,
			Peso 
			)
	VALUES  ( 
			@CategoriaId,
			@Nome,
			@Marca,
			@Fornecedor,
			@Peso
			);

	SELECT SCOPE_IDENTITY();
											 
END
