namespace LoginApp;
using LoginApp.ViewModels;
public partial class LoginPage : ContentPage
{
    private readonly UserServices _userService;

    public LoginPage()
	{
		InitializeComponent();
        var databaseService = new DatabaseServices();
        _userService = new UserServices(databaseService);
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        var email = EmailEntry.Text;
        var password = PasswordEntry.Text;

        var result = await _userService.LoginUserAsync(email, password);
        MessageLabel.Text = result;

        if (result == "Inicio de sesión exitoso")
        {
            await Navigation.PushAsync(new MainPage());
        }
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegisterPage());
    }
}