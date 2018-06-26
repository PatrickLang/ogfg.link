using ogfg.recipeapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            //context.Recipes.Add(new Recipe
            //{
            //    Name = "Jamil's Nutcastle",
            //    LongUrl = "https://www.brewtoad.com/recipes/jamils-nutcastle",
            //    Rating1 = 0,
            //    Rating2 = 1,
            //    Rating3 = 3,
            //    Rating4 = 50,
            //    Rating5 = 100
            //});

            //context.Recipes.Add(new Recipe
            //{
            //    Name = "Munich Helles",
            //    LongUrl = "http://www.malt.io/users/oboyle.todd/recipes/munich-helles",
            //    Rating1 = 0,
            //    Rating2 = 1,
            //    Rating3 = 3,
            //    Rating4 = 50,
            //    Rating5 = 50
            //});

            //context.Recipes.Add(new Recipe
            //{
            //    Name = "Burton Ale",
            //    ShortUrl = "xjlj3",
            //    LongUrl = "http://www.beerxml.com/recipes.xml",
            //    Rating1 = 1,
            //    Rating2 = 2,
            //    Rating3 = 3,
            //    Rating4 = 4,
            //    Rating5 = 5,
            //    BeerXml = new System.IO.StreamReader("samplexml\\burton.xml").ReadToEnd()
            //}
            //);

            //context.Recipes.Add(new Recipe
            //{
            //    Name = "Dry Stout",
            //    ShortUrl = "xj12h",
            //    LongUrl = "http://www.beerxml.com/recipes.xml",
            //    Rating1 = 1,
            //    Rating2 = 2,
            //    Rating3 = 3,
            //    Rating4 = 4,
            //    Rating5 = 5,
            //    BeerXml = new System.IO.StreamReader("samplexml\\dry-stout.xml").ReadToEnd()
            //}
            //);

            //context.Recipes.Add(new Recipe
            //{
            //    Name = "Porter",
            //    ShortUrl = "xj534",
            //    LongUrl = "http://www.beerxml.com/recipes.xml",
            //    Rating1 = 1,
            //    Rating2 = 2,
            //    Rating3 = 3,
            //    Rating4 = 4,
            //    Rating5 = 5,
            //    BeerXml = new System.IO.StreamReader("samplexml\\porter.xml").ReadToEnd()
            //}
            //);

            //context.Recipes.Add(new Recipe
            //{
            //    Name = "Wit",
            //    ShortUrl = "xj43l",
            //    LongUrl = "http://www.beerxml.com/recipes.xml",
            //    Rating1 = 1,
            //    Rating2 = 2,
            //    Rating3 = 3,
            //    Rating4 = 4,
            //    Rating5 = 5,
            //    BeerXml = new System.IO.StreamReader("samplexml\\wit.xml").ReadToEnd()
            //}
            //);


            context.Recipes.Add(new Recipe
            {
                Name = "Black IPA",
                ShortUrl = "ktj3c",
                BeerXml = new System.IO.StreamReader("samplexml\\hbc2018-cda.xml").ReadToEnd()
            });


            context.Recipes.Add(new Recipe
            {
                Name = "Belgian Golden",
                ShortUrl = "pq96x",
                BeerXml = new System.IO.StreamReader("samplexml\\hbc2018-golden.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Grodziskie",
                ShortUrl = "2hnmp",
                BeerXml = new System.IO.StreamReader("samplexml\\hbc2018-grodziskie.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "New England IPA",
                ShortUrl = "m3qw2",
                BeerXml = new System.IO.StreamReader("samplexml\\hbc2018-neipa.xml").ReadToEnd()
            });

            context.SaveChanges();
        }
    }
}
