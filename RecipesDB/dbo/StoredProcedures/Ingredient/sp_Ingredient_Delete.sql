CREATE PROCEDURE [dbo].[sp_Ingredient_Delete]
	@IngredientId int
AS
BEGIN
	delete Ingredient
	where IngredientId = @IngredientId
END

