using MauiStarter2026.Pages;

namespace MauiStarter2026;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        //MainPage = new WelcomePage();
        InitializeComponent();
        MainPage = new NavigationPage(new WelcomePage());
    
    }
}
