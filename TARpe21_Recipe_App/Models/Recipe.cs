using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Recipe
    {
        public string Name { get; set; }   
        public string Subtitle { get; set; }
        public string HeroImage { get; set; }
        public string TotalTime { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public List<string> Images { get; set; }
    }
}
