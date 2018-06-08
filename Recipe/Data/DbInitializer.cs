using ogfg.recipeapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ogfg.recipeapp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RecipeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Recipes.Any())
            {
                return; // Already initialized
            }

            context.Recipes.Add(new Recipe
            {
                Name = "Jamil's Nutcastle",
                LongUrl = "https://www.brewtoad.com/recipes/jamils-nutcastle",
                Rating1 = 0,
                Rating2 = 1,
                Rating3 = 3,
                Rating4 = 50,
                Rating5 = 100
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Munich Helles",
                LongUrl = "http://www.malt.io/users/oboyle.todd/recipes/munich-helles",
                Rating1 = 0,
                Rating2 = 1,
                Rating3 = 3,
                Rating4 = 50,
                Rating5 = 50
            });

            context.SaveChanges();
        }
    }
}
