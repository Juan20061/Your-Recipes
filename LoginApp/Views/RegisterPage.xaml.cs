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
        // L�gica de registro
        string email = EmailEntry.Text;
        string confirmEmail = ConfirmEmailEntry.Text;
        string password = PasswordEntry.Text;
        string confirmPassword = ConfirmPasswordEntry.Text;

        string registrationResult = await _userService.RegisterUserAsync(email, confirmEmail, password, confirmPassword);

        if (registrationResult == "Usuario registrado con �xito")
        {
            await DisplayAlert("Success", registrationResult, "OK");
            await Navigation.PopAsync(); // Vuelve a la p�gina de inicio de sesi�n
        }
        else
        {
            await DisplayAlert("Error", registrationResult, "OK");
        }

    }

    private async Task<bool> RegisterUser()
    {
        // Aqu� implementas tu l�gica de registro
        string password = PasswordEntry.Text;
        string email = EmailEntry.Text;

        // Validar los datos del usuario (ejemplo simple)
        if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
        {
            return false; // Datos inv�lidos
        }

        // Guardar los datos del usuario en una base de datos o servicio
        // Aqu� puedes llamar a un servicio de API o guardar en una base de datos local
        bool databaseSevice = await SaveUserToDatabase(password, email);

        return databaseSevice;
    }

    private Task<bool> SaveUserToDatabase(string password, string email)
    {
        // Simulaci�n de guardar en base de datos (reemplaza esto con tu l�gica real)
        // Por ejemplo, podr�as usar SQLite, un servicio web, etc.
        return Task.FromResult(true); // Cambia esto seg�n tu l�gica
    }



}