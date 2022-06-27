CREATE PROCEDURE [dbo].[sp_Ingredient_Get]
	@id int
AS
BEGIN
	SELECT *
	FROM Ingredient
	WHERE IngredientId = @id
END
