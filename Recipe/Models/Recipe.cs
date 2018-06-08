using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ogfg.recipeapp.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public long Rating1 { get; set; }
        public long Rating2 { get; set; }
        public long Rating3 { get; set; }
        public long Rating4 { get; set; }
        public long Rating5 { get; set; }
        public string LongUrl { get; set; }
        public XDocument BeerXml { get; set; }
    }
}
