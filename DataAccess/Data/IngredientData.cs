using DataAccess.DbAccess;
using DataAccess.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class IngredientData : IIngredientData
    {
        private readonly ISQLServerDataAccess _dataAccess;

        public IngredientData(ISQLServerDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<IEnumerable<Ingredient>> GetAll()
        {
            return await _dataAccess.LoadData<Ingredient, dynamic>("sp_Ingredient_GetAll", new { });
        }

        public async Task Insert(Ingredient ingredient)
        {
            await _dataAccess.SaveData("sp_Ingredient_Insert", new { ingredient.Name });
        }

        public async Task Update(Ingredient ingredient)
        {
            await _dataAccess.SaveData("sp_Ingredient_Update", ingredient);
        }

        public async Task Delete(int id)
        {
            await _dataAccess.SaveData("sp_Ingredient_Delete", new { IngredientId = id });
        }
    }
}
