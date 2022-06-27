CREATE PROCEDURE [dbo].[sp_RecipeIngredient_Insert]
	@recipeId int,
	@ingredientId int,
	@quantity nvarchar(20)
AS
BEGIN
	INSERT INTO RecipeIngredients (RecipeId, IngredientId, Quantity)
	VALUES (@recipeId, @ingredientId, @quantity)
END
