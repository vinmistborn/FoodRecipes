using DataAccess.Entites;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface IRecipeIngredientsData
    {
        Task Delete(int recipeId, int ingredientId);
        Task<RecipeIngredients> Get(int recipeId);
        Task Insert(RecipeIngredients ingredients);
    }
}