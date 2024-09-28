

using LoginApp.Models;
using System.Collections.ObjectModel;

namespace YourRecipes.Models
{
    public class Recipes
    {
        public ObservableCollection<Ingredients> Ingredientes { get; set; }
        public ObservableCollection<Steps> Pasos { get; set; }
        public string Name { get; set; }
        public TimeSpan ReadTime { get; set; }
        public string ImageSource { get; set; }
        public string Description { get; set; }
        public string Preparacion { get; set; }
    }
}
