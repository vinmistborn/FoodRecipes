CREATE PROCEDURE [dbo].[sp_Recipe_Update]
	@RecipeId int,
	@name nvarchar(20),
	@instructions nvarchar(max),
	@photo varbinary(max)
AS
BEGIN
	UPDATE Recipe
	SET Name = @name, Instructions = @instructions, Photo = @photo
	WHERE RecipeId = @RecipeId
END
