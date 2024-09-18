using LoginApp.Models;

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
        await Navigation.PopAsync();
    }
}