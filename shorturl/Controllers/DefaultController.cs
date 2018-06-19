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
            testValues = new Dictionary<string, string>();
            testValues.Add("bs", "http://beersmith.com/");
            testValues.Add("bx", "http://beerxml.com/");
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