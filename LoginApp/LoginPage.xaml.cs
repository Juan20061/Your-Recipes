namespace LoginApp;
using LoginApp.ViewModels;
public partial class LoginPage : ContentPage
{
    //private readonly UserServices _userService;
    private readonly UserServices _userService;


    public LoginPage()
	{
		InitializeComponent();

        var databaseService = new DatabaseServices(); // Inicializa tu servicio de base de datos
        _userService = new UserServices(databaseService); // Inicializa tu servicio de usuario
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // L�gica de autenticaci�n
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;

        string loginResult = await _userService.LoginUserAsync(email, password);

        if (loginResult == "Inicio de sesi�n exitoso")
        {
            // Almacena el token de autenticaci�n de forma segura
            await SecureStorage.SetAsync("auth_token", "your_token_value");

            Application.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Error", loginResult, "OK");
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }

    private async Task<bool> AuthenticateUser()
    {
        // Aqu� implementas tu l�gica de autenticaci�n
        string username = EmailEntry.Text;
        string password = PasswordEntry.Text;

        // Simulaci�n de autenticaci�n (reemplaza esto con tu l�gica real)
        if (username == "user" && password == "password")
        {
            // Autenticaci�n exitosa
            return true;
        }
        else
        {
            // Autenticaci�n fallida
            return false;
        }
    }
}