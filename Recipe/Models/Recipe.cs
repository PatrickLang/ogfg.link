using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ogfg.recipeapp.Models
{
    public class Recipe
    {
        // generated
        public long Id { get; set; }

        // generated / shared with shorturl
        public string ShortUrl { get; set; }

        // Provided when recipe added
        public string Name { get; set; }
        public string Description { get; set; }
        public string LongUrl { get; set; }

        // Optional when recipe added
        public string BeerXml { get; set; }

        // Used by ratings
        public long Rating1 { get; set; }
        public long Rating2 { get; set; }
        public long Rating3 { get; set; }
        public long Rating4 { get; set; }
        public long Rating5 { get; set; }
    }
}
