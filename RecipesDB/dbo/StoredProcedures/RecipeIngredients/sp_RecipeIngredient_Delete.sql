CREATE PROCEDURE [dbo].[sp_RecipeIngredient_Delete]
	@recipeId int,
	@ingredientId int
AS
BEGIN
	DELETE RecipeIngredients
	WHERE RecipeId = @recipeId AND IngredientId = @ingredientId
END