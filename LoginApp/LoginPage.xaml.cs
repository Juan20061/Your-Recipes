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
        // Lógica de autenticación
        string email = EmailEntry.Text;
        string password = PasswordEntry.Text;

        string loginResult = await _userService.LoginUserAsync(email, password);

        if (loginResult == "Inicio de sesión exitoso")
        {
            // Almacena el token de autenticación de forma segura
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
        // Aquí implementas tu lógica de autenticación
        string username = EmailEntry.Text;
        string password = PasswordEntry.Text;

        // Simulación de autenticación (reemplaza esto con tu lógica real)
        if (username == "user" && password == "password")
        {
            // Autenticación exitosa
            return true;
        }
        else
        {
            // Autenticación fallida
            return false;
        }
    }
}