
using LoginApp.Models;

namespace LoginApp.ViewModels
{
    public class AuthService
    {
        // Método para simular el inicio de sesión
        public async Task<bool> LoginAsync(string username, string password)
        {
            // Obtener los datos registrados
            var registeredEmail = await SecureStorage.GetAsync("registered_email");
            var registeredPassword = await SecureStorage.GetAsync("registered_password");

            // Verificar si el usuario y la contraseña coinciden
            if (username == registeredEmail && password == registeredPassword)
            {
                // Guarda un token de autenticación simulado en el almacenamiento seguro
                await SecureStorage.SetAsync("auth_token", "logged_in_user_token");
                return true;
            }
            return false;
        }
        // Método para cerrar sesión
        public async Task LogoutAsync()
        {
            // Eliminar token del almacenamiento seguro
            SecureStorage.Remove("auth_token");
            await Task.CompletedTask;
        }
        // Comprobar si el usuario está autenticado
        public async Task<bool> IsLoggedInAsync()
        {
            var token = await SecureStorage.GetAsync("auth_token");
            return !string.IsNullOrEmpty(token);
        }
        public async Task<bool> RegisterUserAsync(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false; // El registro falla si faltan datos
            }

            // Guardar email y contraseña en almacenamiento seguro (o en base de datos local)
            await SecureStorage.SetAsync("registered_email", email);
            await SecureStorage.SetAsync("registered_password", password);

            // Guardar un token de autenticación
            await SecureStorage.SetAsync("auth_token", "registered_user_token");
            return true;
        }

    }

}
