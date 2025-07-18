namespace pedra_papel_tesoura.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void OnGitHubClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://github.com/djcristianosgp");
    }

    private async void OnInstagramClicked(object sender, EventArgs e)
    {
        await Launcher.Default.OpenAsync("https://instagram.com/djcristianosgp");
    }
}