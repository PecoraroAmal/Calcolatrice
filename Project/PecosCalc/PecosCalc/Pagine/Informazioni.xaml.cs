namespace PecosCalc.Pagine;

public partial class Informazioni : ContentPage
{
    public Informazioni()
    {
        InitializeComponent();
    }
    private async void VG(object sender, TappedEventArgs e)
    {
        try
        {
            await Launcher.OpenAsync("https://istitutogreppi.edu.it/");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Errore", $"Si è verificato un errore: {ex.Message}", "OK");
        }
    }

    private async void Icon(object sender, TappedEventArgs e)
    {
        try
        {
            await Launcher.OpenAsync("https://www.pinterest.it/pin/377880224999766757/");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Errore", $"Si è verificato un errore: {ex.Message}", "OK");
        }
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        CommunityToolkit.Maui.Core.Platform.StatusBar.SetColor(Colors.Black);

        if (((App)App.Current).Tema == "Nero")
        {
            Resources["fgColor"] = Colors.White;
            Resources["bgColor"] = Colors.Black;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.White);
        }
        else if (((App)App.Current).Tema == "Bianco")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.White;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.White);
        }
        else if (((App)App.Current).Tema == "Rosso")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.Red;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.Red);
        }
        else if (((App)App.Current).Tema == "Blu")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.CornflowerBlue;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.CornflowerBlue);
        }
        else if (((App)App.Current).Tema == "Rosa")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.Pink;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.Pink);
        }
        else if (((App)App.Current).Tema == "Giallo")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.Yellow;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.Yellow);
        }
        else if (((App)App.Current).Tema == "Verde")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.Green;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.Green);
        }
        else if (((App)App.Current).Tema == "Viola")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.MediumPurple;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.MediumPurple);
        }
        else if (((App)App.Current).Tema == "Oro")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.Gold;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.Orange);
        }
        else if (((App)App.Current).Tema == "Arancione")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.Orange;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.Orange);
        }
        else if (((App)App.Current).Tema == "Marrone")
        {
            Resources["fgColor"] = Colors.Black;
            Resources["bgColor"] = Colors.Brown;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.Brown);
        }
        else if (((App)App.Current).Tema == "Azzurro")
        {
            Resources["fgColor"] = Colors.White;
            Resources["bgColor"] = Colors.LightSkyBlue;
            AppShell.SetBackgroundColor(this, Colors.Black);
            AppShell.SetTitleColor(this, Colors.LightSkyBlue);
        }
    }
}