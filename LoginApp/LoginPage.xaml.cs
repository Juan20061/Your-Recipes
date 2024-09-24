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

        // Intentar iniciar sesi�n
        bool isAuthenticated = await _authService.LoginAsync(username, password);

        if (isAuthenticated)
        {
            // Guarda el token de autenticaci�n
            await SecureStorage.SetAsync("auth_token", "logged_in_user_token");

            // Redirigir a la p�gina principal si la autenticaci�n fue exitosa
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contrase�a incorrectos", "OK");
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