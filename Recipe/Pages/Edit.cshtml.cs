using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ogfg.recipeapp.Data;
using ogfg.recipeapp.Models;

namespace ogfg.recipeapp.Pages
{
    public class EditModel : PageModel
    {
        private readonly ogfg.recipeapp.Data.RecipeContext _context;

        public EditModel(ogfg.recipeapp.Data.RecipeContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Recipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeExists(Recipe.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RecipeExists(long id)
        {
            return _context.Recipes.Any(e => e.Id == id);
        }
    }
}
