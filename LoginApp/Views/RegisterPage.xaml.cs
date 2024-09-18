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
        var email = EmailEntry.Text;
        var confirmEmail = ConfirmEmailEntry.Text;
        var password = PasswordEntry.Text;
        var confirmPassword = ConfirmPasswordEntry.Text;

        var result = await _userService.RegisterUserAsync(email, confirmEmail, password, confirmPassword);
        MessageLabel.Text = result;

        await Navigation.PushAsync(new LoginPage());

    }



}