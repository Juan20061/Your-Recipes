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

            MainPage = new LoginPage();


        }

        private async Task CheckUserAuthenticationAsync()
        {
            bool isAuthenticated = await _authService.IsLoggedInAsync();

            if (isAuthenticated)
            {
                MainPage = new AppShell(); // Usuario autenticado, navega a la AppShell
            }
            else
            {
                MainPage = new NavigationPage(new LoginPage()); // Redirigir a la página de inicio de sesión
            }
        }
    }
}
