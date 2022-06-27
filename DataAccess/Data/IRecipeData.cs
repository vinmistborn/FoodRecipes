using DataAccess.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface IRecipeData
    {
        Task<Recipe> Get(int id);
        Task<IEnumerable<Recipe>> GetAll();
        Task Insert(Recipe recipe);
        Task Update(Recipe recipe);
    }
}