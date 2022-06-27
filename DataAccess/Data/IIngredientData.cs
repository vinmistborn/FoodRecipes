using DataAccess.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public interface IIngredientData
    {
        Task Delete(int id);
        Task<IEnumerable<Ingredient>> GetAll();
        Task<Ingredient> Get(int id);
        Task Insert(Ingredient ingredient);
        Task Update(Ingredient ingredient);
    }
}