CREATE PROCEDURE [dbo].[sp_Recipe_Insert]
	@name nvarchar(20),
	@instructions nvarchar(max),
	@photo varbinary(max)
AS
BEGIN
	INSERT INTO Recipe (Name, Instructions, Photo)
	VALUES (@name, @instructions, @photo)
END
