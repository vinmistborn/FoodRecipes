using DataAccess.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entites;

namespace FoodRecipes.Controllers
{
    public class IngredientController : Controller
    {
        private readonly IIngredientData _dataAccess;

        public IngredientController(IIngredientData dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<ActionResult<Ingredient>> Index()
        {
            var ingredients = await _dataAccess.GetAll();
            return View(ingredients);
        }

        public ActionResult Create()
        {
            return View();
        }

        // POST: IngredientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {   
                await _dataAccess.Insert(ingredient);
                return RedirectToAction(nameof(Index));
            }
            return View(ingredient);
        }

        // GET: IngredientController/Edit/5
        public async Task<ActionResult<Ingredient>> Edit(int id)
        {
            var ingredient = await _dataAccess.Get(id);
            return View(ingredient);
        }

        // POST: IngredientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Ingredient ingredient)
        {
            if (ModelState.IsValid)
            {
                await _dataAccess.Update(ingredient);
                return RedirectToAction(nameof(Index));
            }

            return View(ingredient);            
        }

        // GET: IngredientController/Delete/5
        public async Task<ActionResult<Ingredient>> Delete(int id)
        {
            var ingredient = await _dataAccess.Get(id);
            return View(ingredient);
        }

        // POST: IngredientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, IFormCollection collection)
        {
            await _dataAccess.Delete(id);
            
            return RedirectToAction(nameof(Index));
        }
    }
}
