CREATE PROCEDURE [dbo].[sp_Ingredient_Delete]
	@id int
AS
BEGIN
	delete Ingredient
	where IngredientId = @id
END

