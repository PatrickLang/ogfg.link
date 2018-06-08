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
    public class DeleteModel : PageModel
    {
        private readonly ogfg.recipeapp.Data.RecipeContext _context;

        public DeleteModel(ogfg.recipeapp.Data.RecipeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Recipe Recipe { get; set; }

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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipes.FindAsync(id);

            if (Recipe != null)
            {
                _context.Recipes.Remove(Recipe);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
