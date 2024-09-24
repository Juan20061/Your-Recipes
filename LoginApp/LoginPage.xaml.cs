namespace LoginApp;

using LoginApp.Models;
using LoginApp.ViewModels;
public partial class LoginPage : ContentPage
{
    //private readonly UserServices _userService;
    private readonly AuthService _authService;



    public LoginPage()
	{
		InitializeComponent();

        _authService = new AuthService();

    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string username = EmailEntry.Text;
        string password = PasswordEntry.Text;

        // Intentar iniciar sesión
        bool isAuthenticated = await _authService.LoginAsync(username, password);

        if (isAuthenticated)
        {
            // Guarda el token de autenticación
            await SecureStorage.SetAsync("auth_token", "logged_in_user_token");

            // Redirigir a la página principal si la autenticación fue exitosa
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
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