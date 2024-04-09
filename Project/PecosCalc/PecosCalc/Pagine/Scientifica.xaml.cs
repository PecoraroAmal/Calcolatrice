using org.matheval;
using System.Text;
namespace PecosCalc.Pagine;

public partial class Scientifica : ContentPage
{
    public bool calcolo = false;
    public bool pi = false;
    public bool nepero = false;
    public List<double> lista = new List<double>();
    public int posizione = -1;
    Object risultato = 0;
    public int sin = 0;
    public int des = 0;
    public Scientifica()
    {
        InitializeComponent();
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
    private void Numero(object sender, EventArgs e)
    {
        if (calcolo == true)
        {
            calcolo = false;
            Testo.Text = "";
        }
        string numero = ((Button)sender).Text;
        if (string.IsNullOrEmpty(numero))
            return;
        if (Testo.Text.Length < 11)
        {
            Testo.Text += numero;
        }
    }

    private void C(object sender, EventArgs e)
    {
        Testo.Text = "";
        Espressione.Text = "";
    }

    private void Reciproco(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Testo.Text) || !char.IsDigit(Testo.Text[^1]))
            return;
        double risultato = 1 / double.Parse(Testo.Text);
        string operazione = $"1/{Testo.Text} = {risultato}";
        Testo.Text = risultato.ToString();
        ((App)App.Current).scientifica.Add(operazione);
    }

    private void Quadrato(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Testo.Text) || !char.IsDigit(Testo.Text[^1]))
            return;
        double risultato = Math.Pow(double.Parse(Testo.Text), 2);
        string operazione = $"{Testo.Text}^2 = {risultato}";
        Testo.Text = risultato.ToString();
        ((App)App.Current).scientifica.Add(operazione);
    }

    private void Radice(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Testo.Text) || !char.IsDigit(Testo.Text[^1]))
            return;
        double risultato = Math.Sqrt(double.Parse(Testo.Text));
        risultato = Math.Round(risultato, 5);
        string operazione = $"√{Testo.Text} = {risultato}";
        Testo.Text = risultato.ToString();
        ((App)App.Current).scientifica.Add(operazione);
    }

    private void Diviso(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Espressione.Text) || !string.IsNullOrEmpty(Testo.Text))
        {
            Espressione.Text += $"{Testo.Text} ÷ ";
            Testo.Text = "";
        }
    }

    private void Per(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Espressione.Text) || !string.IsNullOrEmpty(Testo.Text))
        {
            Espressione.Text += $"{Testo.Text} x ";
            Testo.Text = "";
        }
    }

    private void Meno(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Espressione.Text) || !string.IsNullOrEmpty(Testo.Text))
        {
            Espressione.Text += $"{Testo.Text} - ";
            Testo.Text = "";
        }
    }

    private void Piu(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Espressione.Text) || !string.IsNullOrEmpty(Testo.Text))
        {
            Espressione.Text += $"{Testo.Text} + ";
            Testo.Text = "";
        }
    }

    private void Opposto(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Testo.Text))
            return;
        if (Testo.Text.StartsWith("("))
        {
            if (Testo.Text[1] == '-')
            {
                Testo.Text = Testo.Text.Remove(0, 2);
            }
            else
            {
                Testo.Text = "-" + Testo.Text;
            }
        }
        else
        {
            if (Testo.Text.StartsWith("-"))
            {
                Testo.Text = Testo.Text.Remove(0, 1);
            }
            else
            {
                Testo.Text = "-" + Testo.Text;
            }
        }

    }

    private void Virgola(object sender, EventArgs e)
    {
        if (!Testo.Text.Contains(","))
            Testo.Text += ",";
    }

    private void Uguale(object sender, EventArgs e)
    {
        Espressione.Text += Testo.Text;
        Espressione.Text = Espressione.Text.Replace(',', '.');
        Espressione.Text = Espressione.Text.Replace('÷', '/');
        Espressione.Text = Espressione.Text.Replace('x', '*');
        if (string.IsNullOrEmpty(Espressione.Text))
            return;
        if (pi == true)
        {
            Espressione.Text = Espressione.Text.Replace("3.14", "PI");
        }
        if (nepero == true)
        {
            Espressione.Text = Espressione.Text.Replace("2.71", "e");
        }
        try
        {
            Expression espressione = new Expression(Espressione.Text);
            risultato = espressione.Eval();
        }
        catch (Exception ex)
        {
            DisplayAlert("L'espressione inserita contiene errori:", ex.Message, "OK");
        }

        Espressione.Text = Espressione.Text.Replace('.', ',');
        Espressione.Text = Espressione.Text.Replace('/', '÷');
        Espressione.Text = Espressione.Text.Replace('*', 'x');
        if (Espressione.Text.Contains("PI"))
        {
            Espressione.Text = Espressione.Text.Replace("PI", "3,14");
            pi = false;
        }
        if (Espressione.Text.Contains("e"))
        {
            Espressione.Text = Espressione.Text.Replace("e", "2,71");
            nepero = false;
        }
        Testo.Text = risultato.ToString();
        string operazione = Espressione.Text + "=" + Testo.Text;
        ((App)App.Current).scientifica.Add(operazione);
        Espressione.Text = "";
        calcolo = true;
    }

    private void Cancella(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Testo.Text))
            return;
        Testo.Text = Testo.Text.Remove(Testo.Text.Length - 1);
    }


    private void MC(object sender, EventArgs e)
    {
        lista.Clear();
        posizione = 0;
    }

    private void Mp(object sender, EventArgs e)
    {
        double Valore;
        if (double.TryParse(Testo.Text, out Valore))
        {
            lista[posizione] += Valore;
        }
    }

    private void Mm(object sender, EventArgs e)
    {
        double Valore;
        if (double.TryParse(Testo.Text, out Valore))
        {
            lista[posizione] -= Valore;
        }
    }

    private void MR(object sender, EventArgs e)
    {
        Testo.Text = lista[posizione].ToString();
        lista.Remove(lista[posizione]);
        posizione--;
    }

    private void MS(object sender, EventArgs e)
    {
        double Valore;
        if (double.TryParse(Testo.Text, out Valore))
        {
            lista.Add(Valore);
            posizione++;
        }
    }

    private void M(object sender, EventArgs e)
    {
        StringBuilder popupText = new StringBuilder();
        foreach (double item in lista)
        {
            popupText.AppendLine(item.ToString());
        }

        // Mostra il popup con il testo della lista
        DisplayAlert("Contenuto della lista:", popupText.ToString(), "OK");
    }
    private void Pigreco(object sender, EventArgs e)
    {
        Testo.Text = "3,14";
        pi = true;
    }

    private void Nepero(object sender, EventArgs e)
    {
        Testo.Text = "2,71";
        nepero = true;
    }

    private void ParentesiSin(object sender, EventArgs e)
    {
        Espressione.Text += Testo.Text;
        Espressione.Text += "( ";
        sin++;
    }

    private void ParentesiDes(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Espressione.Text) || !string.IsNullOrEmpty(Testo.Text) && !string.IsNullOrEmpty(Testo.Text))
        {
            Espressione.Text += Testo.Text;
            Espressione.Text += " )";
            Testo.Text = "";
            des++;
        }
    }

    private void Fattoriale(object sender, EventArgs e)
    {
        try
        {
            Espressione.Text += $"fact({Testo.Text})";
            Expression espressione = new Expression(Espressione.Text);
            Object risultato = espressione.Eval();
            Testo.Text = risultato.ToString();
            string operazione = Espressione.Text + "=" + Testo.Text;
            ((App)App.Current).scientifica.Add(operazione);
            Espressione.Text = "";
        }
        catch (Exception ex)
        {
            // Gestione dell'eccezione: puoi stampare un messaggio di errore, registrare l'errore, o gestirlo in altro modo.
            DisplayAlert("Errore:",$"Si è verificato un errore: {ex.Message}", "OK");
        }
    }


    private void Potenza(object sender, EventArgs e)
    {
        Espressione.Text += Testo.Text + "^";
        Testo.Text = "";
    }

    private void DieciAllaX(object sender, EventArgs e)
    {
        Espressione.Text += $"10^({Testo.Text})";
        Testo.Text = "";
    }

    private void Log(object sender, EventArgs e)
    {
        Espressione.Text += $"log10({Testo.Text})";
        Testo.Text = "";
    }

    private void Ln(object sender, EventArgs e)
    {
        Espressione.Text += $"ln({Testo.Text})";
        Testo.Text = "";
    }

    private void Sin(object sender, EventArgs e)
    {
        Espressione.Text += $"sin(";
    }

    private void Cos(object sender, EventArgs e)
    {
        Espressione.Text += $"cos(";
    }

    private void Tan(object sender, EventArgs e)
    {
        Espressione.Text += $"tan(";
    }
    private void exp(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Testo.Text))
        {
            Espressione.Text += $"{Testo.Text},e+";
            Testo.Text = "";
        }
    }
}