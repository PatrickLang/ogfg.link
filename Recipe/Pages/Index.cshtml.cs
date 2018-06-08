using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ogfg.recipeapp.Data;
using ogfg.recipeapp.Models;

namespace ogfg.recipeapp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ogfg.recipeapp.Data.RecipeContext _context;

        public IndexModel(ogfg.recipeapp.Data.RecipeContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipes.ToListAsync();
        }
    }
}
