using LoginApp.ViewModels;

namespace LoginApp;

public partial class RegisterPage : ContentPage
{
    private readonly UserServices _userService;

    public RegisterPage()
	{
		InitializeComponent();
        var databaseService = new DatabaseServices();  // Inicializar el servicio de base de datos
        _userService = new UserServices(databaseService);  // Inicializar el servicio de usuarios

    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        // Lógica de registro
        string email = EmailEntry.Text;
        string confirmEmail = ConfirmEmailEntry.Text;
        string password = PasswordEntry.Text;
        string confirmPassword = ConfirmPasswordEntry.Text;

        string registrationResult = await _userService.RegisterUserAsync(email, confirmEmail, password, confirmPassword);

        if (registrationResult == "Usuario registrado con éxito")
        {
            await DisplayAlert("Success", registrationResult, "OK");
            await Navigation.PopAsync(); // Vuelve a la página de inicio de sesión
        }
        else
        {
            await DisplayAlert("Error", registrationResult, "OK");
        }

    }

    private async Task<bool> RegisterUser()
    {
        // Aquí implementas tu lógica de registro
        string password = PasswordEntry.Text;
        string email = EmailEntry.Text;

        // Validar los datos del usuario (ejemplo simple)
        if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
        {
            return false; // Datos inválidos
        }

        // Guardar los datos del usuario en una base de datos o servicio
        // Aquí puedes llamar a un servicio de API o guardar en una base de datos local
        bool databaseSevice = await SaveUserToDatabase(password, email);

        return databaseSevice;
    }

    private Task<bool> SaveUserToDatabase(string password, string email)
    {
        // Simulación de guardar en base de datos (reemplaza esto con tu lógica real)
        // Por ejemplo, podrías usar SQLite, un servicio web, etc.
        return Task.FromResult(true); // Cambia esto según tu lógica
    }



}