CREATE TABLE [dbo].[Recipe]
(
	[RecipeId] INT NOT NULL PRIMARY KEY Identity(1, 1), 
    [Name] NVARCHAR(20) NOT NULL, 
    [Instructions] NVARCHAR(MAX) NOT NULL, 
    [Photo] VARBINARY(MAX) NULL
)
