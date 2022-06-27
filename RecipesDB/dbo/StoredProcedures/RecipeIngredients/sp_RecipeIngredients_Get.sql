CREATE PROCEDURE [dbo].[sp_RecipeIngredients_Get]
	@recipeId int
AS
BEGIN
	SELECT *
	FROM RecipeIngredients
	WHERE RecipeId = @recipeId
END

