using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ogfg.recipeapp.Data;
using ogfg.recipeapp.Models;

namespace ogfg.recipeapp.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly ogfg.recipeapp.Data.RecipeContext _context;

        public DetailsModel(ogfg.recipeapp.Data.RecipeContext context)
        {
            _context = context;
        }

        public Recipe Recipe { get; set; }

        public float Og { get; set; }
        public float Fg { get; set; }
        public string ABV { get; set; }
        public string Style { get; set; }
        public string Brewer { get; set; }
        public double Rating { get; set; }
        public long RatingCount { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipes.SingleOrDefaultAsync(m => m.Id == id);

            if (Recipe == null)
            {
                return NotFound();
            }

            RatingCount = (Recipe.Rating1 + Recipe.Rating2 + Recipe.Rating3 + Recipe.Rating4 + Recipe.Rating5);
            Rating = (Recipe.Rating1 * 1.0 + Recipe.Rating2 * 2.0 + Recipe.Rating3 * 3.0 + Recipe.Rating4 * 4.0 + Recipe.Rating5 * 5.0) / RatingCount;

            if (string.IsNullOrEmpty(Recipe.BeerXml) == false)
            {
                XDocument recipeXml = XDocument.Parse(Recipe.BeerXml);
                Brewer = recipeXml.Element("RECIPES").Element("RECIPE").Element("BREWER").Value;
                
                float og, fg;
                if (float.TryParse(recipeXml.Element("RECIPES").Element("RECIPE").Element("OG").Value, out og))
                {
                    Og = og;
                }
                if (float.TryParse(recipeXml.Element("RECIPES").Element("RECIPE").Element("FG").Value, out fg))
                {
                    Fg = fg;
                }
                
                ABV = recipeXml.Element("RECIPES").Element("RECIPE").Element("ABV").Value;
                Style = recipeXml.Element("RECIPES").Element("RECIPE").Element("STYLE").Value;
            }
            return Page();
        }
    }
}
