CREATE PROCEDURE [dbo].[sp_Recipe_Update]
	@id int,
	@name nvarchar(20),
	@instructions nvarchar(max),
	@photo varbinary(max)
AS
BEGIN
	UPDATE Recipe
	SET Name = @name, Instructions = @instructions, Photo = @photo
	WHERE RecipeId = @id
END
