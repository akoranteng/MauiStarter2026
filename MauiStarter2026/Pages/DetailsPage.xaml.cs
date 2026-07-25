namespace MauiStarter2026.Pages;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(string message)
    {
        InitializeComponent();

        // Display the message passed from WelcomePage
        MessageLabel.Text = message;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}
