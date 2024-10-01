using LoginApp.Models;
using System.Diagnostics;
namespace LoginApp.Views;

public partial class RecetaDetailPage : ContentPage
{
	public RecetaDetailPage(Recetas receta)
	{
		InitializeComponent();

        // Vincular los datos de la receta
        recetaImage.Source = ImageSource.FromFile(receta.Imagen);
        nombreRecetaLabel.Text = receta.NombreReceta;
        ingredientesValueLabel.Text = receta.Ingredientes;
        tiempoValueLabel.Text = receta.TiempoPreparacion;
        pasosValueLabel.Text = receta.Pasos;
        dificultadValueLabel.Text = GetDificultad(receta.Dificultad);
    }
    private string GetDificultad(int index)
    {
        switch (index)
        {
            case 0: return "Fácil";
            case 1: return "Media";
            case 2: return "Difícil";
            default: return "Desconocida";
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Debug.WriteLine("Intentando volver a la página anterior.");
            // Verifica que haya al menos una página en la pila de navegación
            if (Navigation.NavigationStack.Count > 1)
            {
                await Navigation.PopAsync();
                Debug.WriteLine("Navegación exitosa, regresando a la página anterior.");
            }
            else
            {
                Debug.WriteLine("No hay más páginas para volver.");
                await DisplayAlert("Información", "No hay más páginas para volver.", "Aceptar");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error al intentar volver: {ex.Message}");
            await DisplayAlert("Error", $"Ocurrió un error al intentar volver: {ex.Message}", "Aceptar");
        }
    }
}