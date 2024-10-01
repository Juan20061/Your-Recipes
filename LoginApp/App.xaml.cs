using LoginApp.Models;
using LoginApp.ViewModels;
using LoginApp.Views;

namespace LoginApp
{
    public partial class App : Application
    {
        private readonly AuthService _authService;
        private readonly LocalDbService _dbService;
        public App()
        {
            InitializeComponent();

            _dbService = new LocalDbService();
            _authService = new AuthService();

            // Llama al método de verificación de autenticación
            CheckUserAuthenticationAsync();

            MainPage = new NavigationPage(new LoginPage());


        }

        private async Task CheckUserAuthenticationAsync()
        {
            bool isAuthenticated = await _authService.IsLoggedInAsync();

            // El Shell debe ser instanciado correctamente aquí
            if (isAuthenticated)
            {
                MainPage = new AppShell(); // Asegúrate de que AppShell se inicializa correctamente
            }
            else
            {
                MainPage = new NavigationPage(new LoginPage()); // Redirigir a la página de inicio de sesión
            }
        }
    }
}
