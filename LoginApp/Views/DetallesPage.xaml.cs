using YourRecipes.Models;

namespace YourRecipes.Pages;

public partial class DetallesPage : ContentPage
{
	public DetallesPage( Recipes item)
	{
		InitializeComponent();

		RecipeImage.Source = item.ImageSource;
        RecipeDescription.Text = item.Description;
        RecipeIngredientes.Text = item.Ingredientes;
        RecipePreparacion.Text = item.Preparacion;
    }
}