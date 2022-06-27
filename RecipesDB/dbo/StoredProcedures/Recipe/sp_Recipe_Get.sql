CREATE PROCEDURE [dbo].[sp_Recipe_Get]
	@RecipeId int
AS
BEGIN
	SELECT *
	FROM Recipe
	WHERE RecipeId = @RecipeId
END
