using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourRecipes.Models
{
    public class Recipes
    {
        public string Name { get; set; }
        public TimeSpan ReadTime { get; set; }
        public string ImageSource { get; set; }
        public string Description { get; set; }
        public string Ingredientes { get; set; }
        public string Preparacion { get; set; }
    }
}
