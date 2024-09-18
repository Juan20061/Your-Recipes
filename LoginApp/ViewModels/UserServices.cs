
using LoginApp.Models;

namespace LoginApp.ViewModels
{
    public  class UserServices
    {
        private readonly DatabaseServices _databaseService;

        public UserServices(DatabaseServices databaseService)
        {
            _databaseService = databaseService;
        }

        public async Task<string> RegisterUserAsync(string email, string confirmEmail, string password, string confirmPassword)
        {
            // Verificar si el correo y el confirmar correo coinciden
            if (email != confirmEmail)
                return "Los correos electrónicos no coinciden";

            // Verificar si la contraseña y confirmar contraseña coinciden
            if (password != confirmPassword)
                return "Las contraseñas no coinciden";

            // Verificar si ya existe un usuario con el mismo correo
            var existingUser = await _databaseService.GetUserByEmailAsync(email);
            if (existingUser != null)
                return "Este correo electrónico ya está registrado";

            // Crear el nuevo usuario
            var user = new User
            {
                Email = email,
                ConfirmEmail = confirmEmail,
                Password = password,
                ConfirmPassword = confirmPassword
            };

            await _databaseService.AddUserAsync(user);
            return "Usuario registrado con éxito";
        }

        // Método para inicio de sesión
        public async Task<string> LoginUserAsync(string email, string password)
        {
            var user = await _databaseService.LoginUserAsync(email, password);

            if (user == null)
                return "Correo o contraseña incorrectos";

            return "Inicio de sesión exitoso";
        }
    }
}
