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
            case 0: return "F�cil";
            case 1: return "Media";
            case 2: return "Dif�cil";
            default: return "Desconocida";
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Debug.WriteLine("Intentando volver a la p�gina anterior.");
            // Verifica que haya al menos una p�gina en la pila de navegaci�n
            if (Navigation.NavigationStack.Count > 1)
            {
                await Navigation.PopAsync();
                Debug.WriteLine("Navegaci�n exitosa, regresando a la p�gina anterior.");
            }
            else
            {
                Debug.WriteLine("No hay m�s p�ginas para volver.");
                await DisplayAlert("Informaci�n", "No hay m�s p�ginas para volver.", "Aceptar");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error al intentar volver: {ex.Message}");
            await DisplayAlert("Error", $"Ocurri� un error al intentar volver: {ex.Message}", "Aceptar");
        }
    }
}