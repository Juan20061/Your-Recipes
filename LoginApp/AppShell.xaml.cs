using LoginApp.Models;
using LoginApp.Views;
using LoginApp.ViewModels;


namespace LoginApp
{
    public partial class AppShell : Shell
    {
        private readonly LocalDbService _dbService;
        private readonly AuthService _autheService;


        public AppShell()
        {
            InitializeComponent();

            // Inicializa el servicio de base de datos
            _dbService = new LocalDbService();
            _autheService = new AuthService();

            // Crea las secciones de Shell y pasa el servicio de base de datos
            CreateShellSections();

        }
       private void CreateShellSections()
    {
        // Página de Inicio
        var homeSection = new ShellSection
        {
            Title = "Inicio",
            Icon = "home.png",
            
        };
        homeSection.Items.Add(new ShellContent
        {
            ContentTemplate = new DataTemplate(() => new MainPage())
        });

        // Página Agregar
        var addRecipeSection = new ShellSection
        {
            Title = "Agregar",
            Icon = "nueva.png",
        };
        addRecipeSection.Items.Add(new ShellContent
        {
            ContentTemplate = new DataTemplate(() => new AddRecipePage(_dbService))
        });

        // Página Crear Cuenta
        var registerSection = new ShellSection
        {
            Title = "Crear Cuenta",
            Icon = "perfil.png",
        };
        registerSection.Items.Add(new ShellContent
        {
            ContentTemplate = new DataTemplate(() => new RegisterPage())
        });

        // Página Mis Recetas
        var myRecipesSection = new ShellSection
        {
            Title = "Mis Recetas",
            Icon = "uten1.png",
        };


        //myRecipesSection.Items.Add(new ShellContent
        //{
        //    ContentTemplate = new DataTemplate(() => new MeRecipePage())
        //});

        // Agregar secciones a Shell
        Items.Add(homeSection);
        Items.Add(addRecipeSection);
        Items.Add(registerSection);
        Items.Add(myRecipesSection);
    }
        private async void OnLogout_Clicked(object sender, EventArgs e)
        {
            await _autheService.LogoutAsync();

            // Cerrar el Flyout si está abierto
            if (Shell.Current.FlyoutIsPresented)
            {
                Shell.Current.FlyoutIsPresented = false;
            }

            // Redirigir a la página de inicio de sesión
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());


        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddRecipePage(_dbService));

        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());

        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MeRecipePage());
        }
    }
}
