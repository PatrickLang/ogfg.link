using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace shorturl.Controllers
{
    [Route("/")]
    public class DefaultController : Controller
    {
        private Dictionary<string, string> testValues;
        private Random random = new Random();

        public DefaultController()
        {
            string recipePrefix = "http://recipe.ogfg.link/Details?ShortUrl=";
            testValues = new Dictionary<string, string>();
            testValues.Add("bs", "http://beersmith.com/");
            testValues.Add("bx", "http://beerxml.com/");
            testValues.Add("ktj3c", recipePrefix + "ktj3c");
            testValues.Add("w6tyx", recipePrefix + "w6tyx");
            testValues.Add("pq96x", recipePrefix + "pq96x");
            testValues.Add("2hnmp", recipePrefix + "2hnmp");
            testValues.Add("vb6md", recipePrefix + "vb6md");
            testValues.Add("m3qw2", recipePrefix +"m3qw2");
            testValues.Add("p7xvt", recipePrefix +"p7xvt");
            testValues.Add("ae2br", recipePrefix +"ae2br");
            testValues.Add("br2lx", recipePrefix +"br2lx");
            testValues.Add("u4bxm", recipePrefix +"u4bxm");
            testValues.Add("4fgpx", recipePrefix +"4fgpx");
            testValues.Add("xt3wb", recipePrefix +"xt3wb");
            testValues.Add("k7bwq", recipePrefix +"k7bwq");
            testValues.Add("h29kz", recipePrefix +"h29kz");
            testValues.Add("p5mwq", recipePrefix +"p5mwq");
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            try
            {
                return new RedirectResult(testValues[id]);
            } catch (KeyNotFoundException)
            {
                // Note - if there's a file in wwwroot matching the GET request, this will not be reached.
                return new NotFoundResult();
            }
        }

        [HttpGet("random")]
        public IActionResult Get()
        {
            return new RedirectResult(testValues.ElementAt(random.Next() % testValues.Count).Value);
        }
    }
}