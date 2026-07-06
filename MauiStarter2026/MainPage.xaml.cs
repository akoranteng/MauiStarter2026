namespace MauiStarter2026;

public partial class MainPage : ContentPage
{
    private int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;
        ((Button)sender).Text = $"Clicked {count} times";
    }
}
