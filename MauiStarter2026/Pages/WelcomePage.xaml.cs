using MauiStarter2026.Pages;

namespace MauiStarter2026.Pages;

public partial class WelcomePage : ContentPage
{
    public WelcomePage()
    {
        InitializeComponent();
    }

    private async void OnNavigateButtonClicked(object sender, EventArgs e)
    {
        // Module 04: Passing a simple string parameter to DetailsPage
        string message = "Welcome from Module 04";

        await Navigation.PushAsync(new DetailsPage(message));
    }
}
