using DataAccess.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipes.Controllers
{
    public class RecipeIngredientsController : Controller
    {
        private readonly IRecipeIngredientsData _dataAccess;

        public RecipeIngredientsController(IRecipeIngredientsData dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: RecipeIngredientsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecipeIngredientsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecipeIngredientsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipeIngredientsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecipeIngredientsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecipeIngredientsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecipeIngredientsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
