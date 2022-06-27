CREATE PROCEDURE [dbo].[sp_Recipe_Get]
	@id int
AS
BEGIN
	SELECT *
	FROM Recipe
	WHERE RecipeId = @id
END
