namespace LoginApp.Views;

public partial class MeRecipePage : ContentPage
{
	public MeRecipePage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new MainPage());
    }
}