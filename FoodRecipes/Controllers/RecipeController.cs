using DataAccess.Data;
using DataAccess.Entites;
using FoodRecipes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipes.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeData _dataAccess;

        public RecipeController(IRecipeData dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<ActionResult<Recipe>> Index()
        {
            var recipes = await _dataAccess.GetAll();
            return View(recipes);
        }

        public async Task<ActionResult> Details(int id)
        {
            var recipe = await _dataAccess.Get(id);
            return View(recipe);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RecipeViewModel model)
        {
            try
            {
                byte[] photoBytes = ConvertFileToByteArray(model.Photo);

                var recipe = new Recipe
                {
                    Name = model.Name,
                    Instructions = model.Instructions,
                    Photo = photoBytes
                };

                await _dataAccess.Insert(recipe);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }

        public async Task<ActionResult<RecipeViewModel>> Edit(int id)
        {
            var recipe = await _dataAccess.Get(id);

            var model = new RecipeViewModel
            {
                RecipeId = recipe.RecipeId,
                Name = recipe.Name,
                Instructions = recipe.Instructions
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(RecipeViewModel model)
        {
            try
            {
                byte[] photoBytes = ConvertFileToByteArray(model.Photo);

                var recipe = new Recipe
                {
                    RecipeId = model.RecipeId,
                    Name = model.Name,
                    Instructions = model.Instructions,
                    Photo = photoBytes
                };

                await _dataAccess.Update(recipe);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View(model);
            }
        }

        public async Task<ActionResult> ShowImage(int? id)
        {
            if (id.HasValue)
            {
                var item = await _dataAccess.Get(id ?? -1);
                if (item?.Photo != null)
                {
                    return File(
                        item.Photo,
                        "image/jpeg",
                        $"recipe_{id}.jpg");
                }
            }

            return NotFound();
        }

        public byte[] ConvertFileToByteArray(IFormFile photo)
        {
            byte[] photoBytes = null;
            if (photo != null)
            {
                using (var memory = new MemoryStream())
                {
                    photo.CopyTo(memory);
                    photoBytes = memory.ToArray();
                }
            }

            return photoBytes;
        }
    }
}
