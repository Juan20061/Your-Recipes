using LoginApp.Models;




namespace LoginApp.Views;

public partial class AddRecipePage : ContentPage
{
    private readonly LocalDbService _dbService;
    private int _editRecetaId;
    private string _imagePath;
    private string _selectedIngredients;

    private readonly List<string> _ingredientesDisponibles = new List<string> { "Harina", "Huevos", "Leche", "Azúcar", "Mapache" };

    public AddRecipePage(LocalDbService dbService)
	{
		InitializeComponent();
        _dbService = dbService;

        LoadRecetas();

        Task.Run(async () => listview.ItemsSource = await _dbService.GetRecetasAsync());

    }

    public AddRecipePage()
    {
    }

    private async void LoadRecetas()
    {
        listview.ItemsSource = await _dbService.GetRecetasAsync();
    }

    private async void AddIngredients_Clicked(object sender, EventArgs e)
    {
        var ingredients = await DisplayActionSheet("Selecciona los ingredientes", "Cancelar", null, _ingredientesDisponibles.ToArray());

        if (ingredients != null && ingredients != "Cancelar")
        {
            _selectedIngredients = string.IsNullOrEmpty(_selectedIngredients) ? ingredients : $"{_selectedIngredients}, {ingredients}";
            SelectedIngredientsLabel.Text = _selectedIngredients;
        }
    }

    private async  void SelectImageButton_Clicked(object sender, EventArgs e)
    {
        var result = await FilePicker.PickAsync(new PickOptions
        {
            FileTypes = FilePickerFileType.Images,
            PickerTitle = "Selecciona una imagen"
        });

        if (result != null)
        {
            _imagePath = result.FullPath;
            recetaImage.Source = ImageSource.FromFile(_imagePath);
        }
    }

    private async void saveButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            if (!ValidateInputs())
                return;

            var receta = CreateRecetaFromInputs();

            if (_editRecetaId == 0)
                await _dbService.Create(receta);
            else
            {
                receta.Id = _editRecetaId;
                await _dbService.Update(receta);
                _editRecetaId = 0;
            }

            ClearInputs();
            LoadRecetas();
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "Ocurrió un error: " + ex.Message, "Aceptar");
        }
    }

    private bool ValidateInputs()
    {
        if (string.IsNullOrEmpty(Xreceta.Text) ||
            string.IsNullOrEmpty(_selectedIngredients) ||
            string.IsNullOrEmpty(tiempo.Text) ||
            string.IsNullOrEmpty(_imagePath) ||
            string.IsNullOrEmpty(Xpasos.Text))
        {
            DisplayAlert("Error", "Por favor, completa todos los campos obligatorios.", "Aceptar");
            return false;
        }

        return true;
    }

    private Recetas CreateRecetaFromInputs()
    {
        return new Recetas
        {
            NombreReceta = Xreceta.Text,
            Ingredientes = _selectedIngredients,
            TiempoPreparacion = tiempo.Text,
            Imagen = _imagePath,
            Dificultad = dificultadPicker.SelectedIndex,
            Pasos = Xpasos.Text
        };
    }

    private void ClearInputs()
    {
        Xreceta.Text = string.Empty;
        _selectedIngredients = string.Empty;
        SelectedIngredientsLabel.Text = string.Empty;
        tiempo.Text = string.Empty;
        _imagePath = null;
        recetaImage.Source = null;
        Xpasos.Text = string.Empty; // Limpiar los pasos
    }

    private async Task DeleteReceta(Recetas receta)
    {
        await _dbService.Delete(receta);
        LoadRecetas();
    }

    private void PopulateInputsForEditing(Recetas receta)
    {
        _editRecetaId = receta.Id;
        Xreceta.Text = receta.NombreReceta;
        _selectedIngredients = receta.Ingredientes;
        SelectedIngredientsLabel.Text = receta.Ingredientes;
        tiempo.Text = receta.TiempoPreparacion;
        _imagePath = receta.Imagen;
        recetaImage.Source = ImageSource.FromFile(_imagePath);
        dificultadPicker.SelectedIndex = receta.Dificultad;
        Xpasos.Text = receta.Pasos;
    }

    private async void listview_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item == null) return; // No hacer nada si el ítem es nulo

        var receta = (Recetas)e.Item;

        // Mostrar el ActionSheet con opciones para editar, eliminar o ver detalles
        var action = await DisplayActionSheet("Acción", "Cancelar", null, "Editar", "Eliminar", "Ver Detalles");

        switch (action)
        {
            case "Editar":
                PopulateInputsForEditing(receta);
                break;

            case "Eliminar":
                await DeleteReceta(receta);
                break;

            case "Ver Detalles":
                // Navegar a la página de detalles de la receta
                await Navigation.PushAsync(new RecetaDetailPage(receta));
                break;
        }
    }
}