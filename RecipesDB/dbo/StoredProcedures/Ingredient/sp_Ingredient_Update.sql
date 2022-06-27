CREATE PROCEDURE [dbo].[sp_Ingredient_Update]
	@id int,
	@name nvarchar(50)
AS
BEGIN
	update Ingredient
	set Name = @name
	where IngredientId = @id
END
