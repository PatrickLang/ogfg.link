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
            //    BeerXml = new System.IO.StreamReader("SampleXml/burton.xml").ReadToEnd()
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
            //    BeerXml = new System.IO.StreamReader("SampleXml/dry-stout.xml").ReadToEnd()
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
            //    BeerXml = new System.IO.StreamReader("SampleXml/porter.xml").ReadToEnd()
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
            //    BeerXml = new System.IO.StreamReader("SampleXml/wit.xml").ReadToEnd()
            //}
            //);


            context.Recipes.Add(new Recipe
            {
                Name = "BOB's",
                Style = "Black IPA",
                ShortUrl = "ktj3c",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-cda.xml").ReadToEnd()
            });


            context.Recipes.Add(new Recipe
            {
                Name = "Double R",
                Style = "Munich Dunkel",
                ShortUrl = "w6tyx",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-dunkel.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Diane's",
                Style = "Belgian Golden",
                ShortUrl = "pq96x",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-golden.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Firewalker",
                Style = "Grodziskie",
                ShortUrl = "2hnmp",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-grodziskie.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Mill",
                Style = "English Mild",
                ShortUrl = "vb6md",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-mild.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Peculiar Owl",
                Style = "New England IPA",
                ShortUrl = "m3qw2",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-neipa.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Penny Loafer",
                Style = "Pilsner",
                ShortUrl = "p7xvt",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-pils.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Black Lodge",
                Style = "Schwarzbier",
                ShortUrl = "ae2br",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-schwarzbier.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Log Lady",
                Style = "Spruce Brown Ale",
                ShortUrl = "br2lx",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-spruce.xml").ReadToEnd()
            });

            context.Recipes.Add(new Recipe
            {
                Name = "Overnight White",
                Style = "Wit",
                ShortUrl = "u4bxm",
                BeerXml = new System.IO.StreamReader("SampleXml/hbc2018-wit.xml").ReadToEnd()
            });


            context.Recipes.Add(new Recipe{
                Name = "Great Northern",
                Style = "Apple Cider",
                ShortUrl = "4fgpx"
                // Zot
            });

            context.Recipes.Add(new Recipe{
                Name = "Bookhouse Boys",
                Style = "Ginger Saison",
                ShortUrl = "xt3wb"
            });

            context.Recipes.Add(new Recipe{
                Name = "One Eyed Jack's",
                Style = "Lichtenhainer",
                ShortUrl = "k7bwq"
            });


            context.Recipes.Add(new Recipe{
                Name = "Damn Good",
                Style = "Wee Heavy",
                ShortUrl = "h29kz"
            });

            context.Recipes.Add(new Recipe{
                Name = "Big Ed's",
                Style = "Apple Cider",
                ShortUrl = "p5mwq"
            });

            context.SaveChanges();
        }
    }
}
