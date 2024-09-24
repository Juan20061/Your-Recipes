using LoginApp.ViewModels;
using System.Threading.Tasks;

namespace LoginApp;

public partial class RegisterPage : ContentPage
{
    private readonly AuthService _authService;
    public RegisterPage()
	{
		InitializeComponent();
        _authService = new AuthService();  // Inicializa AuthService aqu�

    }

    private async void OnRegisterClicked(object sender, EventArgs e)
    {
        string email = EmailEntry.Text;
        string confirmEmail = ConfirmEmailEntry.Text;
        string password = PasswordEntry.Text;
        string confirmPassword = ConfirmPasswordEntry.Text;

        // Validar los datos de registro
        string validationMessage = ValidateRegistrationForm(email, confirmEmail, password, confirmPassword);

        if (!string.IsNullOrEmpty(validationMessage))
        {
            await DisplayAlert("Error", validationMessage, "OK");
            return;
        }

        // Registrar usuario usando AuthService
        bool registrationSuccess = await RegisterUserAsync(email, password);

        if (registrationSuccess)
        {
            await DisplayAlert("�xito", "Usuario registrado con �xito", "OK");
            await Navigation.PopAsync(); // Vuelve a la p�gina de inicio de sesi�n
        }
        else
        {
            await DisplayAlert("Error", "Error en el registro. Int�ntalo de nuevo.", "OK");
        }
    }

    private string ValidateRegistrationForm(string email, string confirmEmail, string password, string confirmPassword)
    {
        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(confirmEmail) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
        {
            return "Todos los campos son obligatorios.";
        }

        if (!email.Equals(confirmEmail))
        {
            return "Los correos electr�nicos no coinciden.";
        }

        if (!password.Equals(confirmPassword))
        {
            return "Las contrase�as no coinciden.";
        }

        if (password.Length < 6)
        {
            return "La contrase�a debe tener al menos 6 caracteres.";
        }

        return string.Empty; // No hay errores
    }

    private async Task<bool> RegisterUserAsync(string email, string password)
    {
        try
        {
            // Llama a AuthService para registrar el usuario
            var result = await _authService.RegisterUserAsync(email, password);
            return result; // Si el resultado es true, el registro fue exitoso
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", "No se pudo registrar el usuario. Por favor, int�ntalo m�s tarde.", "OK");
            Console.WriteLine(ex.Message);  // Manejamos cualquier excepci�n durante el registro
            return false;
        }
    }

}



