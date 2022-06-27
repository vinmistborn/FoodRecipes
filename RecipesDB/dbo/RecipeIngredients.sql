CREATE TABLE [dbo].[RecipeIngredients]
(
	[RecipeId] INT NOT NULL, 
    [IngredientId] INT NOT NULL, 
    [Quantity] NVARCHAR(20) NOT NULL,

    constraint pk_recipeIngredient primary key (RecipeId, IngredientId),
    constraint fk_recipeIngredient_recipe foreign key (RecipeId) references Recipe(RecipeId) on delete cascade on update cascade,
    constraint fk_recipeIngredient_ingredient foreign key (IngredientId) references Ingredient(IngredientId) on delete cascade  on update cascade
)
