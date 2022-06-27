CREATE PROCEDURE [dbo].[sp_Ingredient_Insert]
	@name nvarchar(50)
AS
BEGIN
	INSERT INTO Ingredient (Name) VALUES (@name)
END
