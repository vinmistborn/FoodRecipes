using DataAccess.DbAccess;
using DataAccess.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class RecipeData : IRecipeData
    {
        private readonly ISQLServerDataAccess _dataAccess;

        public RecipeData(ISQLServerDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<Recipe>> GetAll()
        {
            return await _dataAccess.LoadData<Recipe, dynamic>("sp_Recipe_GetAll", new { });
        }

        public async Task<Recipe> Get(int recipeId)
        {
            var recipe = await _dataAccess.LoadData<Recipe, dynamic>("sp_Recipe_Get", new { recipeId });
            return recipe.FirstOrDefault();
        }

        public async Task Insert(Recipe recipe)
        {
            await _dataAccess.SaveData("sp_Recipe_Insert", new { recipe.Name, recipe.Instructions, recipe.Photo });
        }

        public async Task Update(Recipe recipe)
        {
            await _dataAccess.SaveData("sp_Recipe_Update", recipe);
        }
    }
}
