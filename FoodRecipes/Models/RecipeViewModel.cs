using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodRecipes.Models
{
    public class RecipeViewModel
    {
        public int RecipeId { get; set; }
        public string Name { get; set; }
        public string Instructions { get; set; }
        
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }
    }
}
