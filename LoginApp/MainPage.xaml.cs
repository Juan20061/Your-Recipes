using System.Collections.ObjectModel;
using YourRecipes.Models;
using YourRecipes.Pages;

namespace LoginApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Recipes> Recetas { get; set; } //Colección Recipes
        public ObservableCollection<Recipes> Recetas2 { get; set; } //Colección para orden diferente
        
        public MainPage()
        {
            InitializeComponent();
            InitializeRecipes();
            BindingContext = this;
        }

        private void InitializeRecipes()
        {
            Recetas = new ObservableCollection<Recipes>
            {
                new Recipes {Name = "Waffle con Fruta", ReadTime = new TimeSpan(0, 30, 0),ImageSource = "waffle.jfif", Description = "Waffle con fruta", Ingredientes = "Ingredientes: Harina, Leche, Huevos, Frutas.", Preparacion = "Instrucciones: Mezclar, cocinar y servir." },
                new Recipes {Name = "Postre Tres Leches", ReadTime = new TimeSpan(0, 30, 0),ImageSource = "pastel_tres_leches.jpg", Description = "Postre de tres leches", Ingredientes = "Ingredientes: ", Preparacion = ""},
                new Recipes {Name = "Brazo Gitano de Crema", ReadTime = new TimeSpan(0, 30, 0),ImageSource = "brazo_gitano.jpg", Description = "Brazo gitano de crema", Ingredientes = "Ingredientes: ", Preparacion =""},
                new Recipes {Name = "Churritos Azucarados", ReadTime = new TimeSpan(0, 30, 0),ImageSource = "churros.jfif", Description = "Churros españoles", Ingredientes = "Ingredientes: ", Preparacion = ""},
            };
            Recetas2 = new ObservableCollection<Recipes>
            {
                new Recipes {Name = "Galletas con Chispas de chocolate", ReadTime = new TimeSpan(0, 30, 0),ImageSource = "gallet.jfif", Description = "Galletas con chispas de chocolate", Ingredientes = "Ingredientes: Harina, Leche, Huevos, Avena.", Preparacion = ""},
                new Recipes {Name = "Pan Integral", ReadTime = new TimeSpan(0, 30, 0),ImageSource = "pan.jfif", Description = "Pan integral", Ingredientes = "Ingredientes: ", Preparacion = ""},
                new Recipes {Name = "Budín", ReadTime = new TimeSpan(0, 30, 0),ImageSource = "budin.jfif", Description = "Budín", Ingredientes = "Ingredientes: ", Preparacion = ""},
                new Recipes {Name = "Rollos de Canela", ReadTime = new TimeSpan(0, 30, 0),ImageSource = "rollos.jfif", Description = "Rollos de canela", Ingredientes = "Ingredientes:", Preparacion = ""},
                new Recipes {Name = "Tacos", ReadTime = new TimeSpan(0, 30, 0),ImageSource = "tacos.jfif", Description = "Tacos", Ingredientes = "Ingredientes: ", Preparacion= ""},
            };
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            var button = sender as ImageButton;
            var item = button.BindingContext as Recipes;
            if (item != null)
            {
                await Navigation.PushAsync(new DetallesPage(item));
            }
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            var button1 = sender as ImageButton;
            var item = button1.BindingContext as Recipes;
            if (item != null)
            {
                await Navigation.PushAsync(new DetallesPage(item));
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {

        }
    }

}
