namespace LoginApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnLogout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();

        }
    }
}
