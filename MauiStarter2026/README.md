# Module 04 — Navigation With Parameters  
This module introduces page-to-page navigation in .NET MAUI using parameters.  
The goal is to pass data from one page (WelcomePage) to another (DetailsPage)  
and display the received value.

---

## ✔ What This Module Covers
- Creating two pages: `WelcomePage` and `DetailsPage`
- Navigating using `Navigation.PushAsync`
- Passing a string parameter to the destination page
- Displaying the parameter on the DetailsPage
- Updating `AppShell.xaml` to load the new WelcomePage

---

## ✔ Files Added / Updated
### **AppShell.xaml**
Registers `WelcomePage` as the startup page.

### **WelcomePage.xaml / WelcomePage.xaml.cs**
Contains a button that navigates to `DetailsPage`  
and passes a string parameter.

### **DetailsPage.xaml / DetailsPage.xaml.cs**
Receives the parameter and displays it in a label.

---

## ✔ Navigation Flow
1. User taps **Go to Details Page**  
2. `WelcomePage` calls:

```csharp
await Navigation.PushAsync(new DetailsPage(message));
dotnet build -t:Run -f net8.0-ios

dotnet clean
dotnet build -f net8.0-ios
dotnet build -t:Run -f net8.0-ios
