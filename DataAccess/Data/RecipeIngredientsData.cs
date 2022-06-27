using DataAccess.DbAccess;
using DataAccess.Entites;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class RecipeIngredientsData : IRecipeIngredientsData
    {
        private readonly ISQLServerDataAccess _dataAccess;

        public RecipeIngredientsData(ISQLServerDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task Insert(RecipeIngredients ingredients)
        {
            await _dataAccess.SaveData("sp_RecipeIngredient_Insert", ingredients);
        }

        public async Task Delete(int recipeId, int ingredientId)
        {
            await _dataAccess.SaveData("sp_RecipeIngredient_Delete", new { RecipeId = recipeId, IngredientId = ingredientId });
        }

        public async Task<RecipeIngredients> Get(int recipeId)
        {
            var recipe = await _dataAccess.LoadData<RecipeIngredients, dynamic>("sp_RecipeIngredient_Get", new { recipeId });
            return recipe.FirstOrDefault();
        }
    }
}
