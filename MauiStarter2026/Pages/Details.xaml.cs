using Microsoft.Maui.Controls;

namespace MauiStarter2026.Pages;

public partial class DetailsPage : ContentPage
{
    public DetailsPage()
    {
        InitializeComponent();
    }

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}
