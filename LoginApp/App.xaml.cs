using LoginApp.Models;
using LoginApp.Views;

namespace LoginApp
{
    public partial class App : Application
    {
        private readonly LocalDbService _dbService;

        public App()
        {
            InitializeComponent();

            // Verifica si el usuario está autenticado
            bool isAuthenticated = CheckUserAuthentication();

            if (isAuthenticated)
            {
                MainPage = new AppShell();
            }
            else
            {
                MainPage = new NavigationPage(new LoginPage());
            }

        }

        private bool CheckUserAuthentication()
        {
            // Intenta obtener el token de autenticación del almacenamiento seguro
            var token = SecureStorage.GetAsync("auth_token").Result;

            // Si no hay token, redirige al usuario a la página de inicio de sesión
            if (string.IsNullOrEmpty(token))
            {
                return false;
            }

            // Si hay un token, considera al usuario autenticado
            return true;
        }
    }
}
