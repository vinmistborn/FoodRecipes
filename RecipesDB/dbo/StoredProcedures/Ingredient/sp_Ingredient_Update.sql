CREATE PROCEDURE [dbo].[sp_Ingredient_Update]
	@IngredientId int,
	@name nvarchar(50)
AS
BEGIN
	update Ingredient
	set Name = @name
	where IngredientId = @IngredientId
END
