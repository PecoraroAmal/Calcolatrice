using org.matheval;
using System.Text;

namespace PecosCalc.Pagine;

public partial class Standard : ContentPage
{
    public bool calcolo;
    public double list = 0;
    public List<String> espressione = new List<String>();
    public List<double> lista = new List<double>();
    public int posizione = -1;
    public Standard()
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
        if(calcolo == true)
        {
            Testo.Text = "";
            Espressione.Text = "";
            espressione.Clear();
            calcolo = false;
        }
        string numero = ((Button)sender).Text;
        if (string.IsNullOrEmpty(numero))
            return;
        if (Testo.Text.Length < 11)
        {
            Testo.Text += numero;
        }
    }

    private void Percento(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Testo.Text))
        {
            if (espressione.Count == 0)
            {
                Testo.Text = "";
            }
            else
            {
                double percentuale = double.Parse(Testo.Text);
                double numero = double.Parse(espressione[0]);
                double risultato = numero*percentuale / 100;
                Espressione.Text += risultato;
                espressione.Add(risultato.ToString());
            }
            Testo.Text = "";
        }
    }

    private void CE(object sender, EventArgs e)
    {
        Testo.Text = "";
    }

    private void C(object sender, EventArgs e)
    {
        Testo.Text = "";
        Espressione.Text = "";
        espressione.Clear();
    }

    private void Reciproco(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Testo.Text) || !char.IsDigit(Testo.Text[^1]))
            return;
        double risultato = 1 / double.Parse(Testo.Text);
        Testo.Text = risultato.ToString();
    }

    private void Quadrato(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Testo.Text) || !char.IsDigit(Testo.Text[^1]))
            return;
        double risultato = Math.Pow(double.Parse(Testo.Text), 2);
        Testo.Text = risultato.ToString();
    }

    private void Radice(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(Testo.Text) || !char.IsDigit(Testo.Text[^1]))
            return;
        double risultato = Math.Sqrt(double.Parse(Testo.Text));
        risultato = Math.Round(risultato, 5);
        Testo.Text = risultato.ToString();
    }

    private void Diviso(object sender, EventArgs e)
    {
        if (calcolo == true)
        {
            calcolo = false;
        }
        if (!string.IsNullOrEmpty(Testo.Text))
        {
            if (espressione.Count == 0)
            {
                espressione.Add(Testo.Text);
                espressione.Add("÷");
                Espressione.Text = $"{Testo.Text} ÷ ";
            }
            else
            {
                espressione.Add(Testo.Text);
                string primoElemento = espressione[0];
                string secondoElemento = espressione[1];
                string terzoElemento = espressione[2];
                double risultato = Calcola(primoElemento, secondoElemento, terzoElemento);
                Espressione.Text = $"{risultato} ÷ ";
                espressione.Clear();
                espressione.Add(risultato.ToString());
                espressione.Add("÷");
            }
            Testo.Text = "";
        }
    }

    private void Per(object sender, EventArgs e)
    {
        if (calcolo == true)
        {
            calcolo = false;
        }
        if (!string.IsNullOrEmpty(Testo.Text))
        {
            if (espressione.Count == 0)
            {
                espressione.Add(Testo.Text);
                espressione.Add("x");
                Espressione.Text = $"{Testo.Text} x ";
            }
            else
            {

                espressione.Add(Testo.Text);
                string primoElemento = espressione[0];
                string secondoElemento = espressione[1];
                string terzoElemento = espressione[2];
                double risultato = Calcola(primoElemento, secondoElemento, terzoElemento);
                Espressione.Text = $"{risultato} x ";
                espressione.Clear();
                espressione.Add(risultato.ToString());
                espressione.Add("x");
            }
            Testo.Text = "";
        }
    }

    private void Meno(object sender, EventArgs e)
    {
        if (calcolo == true)
        {
            calcolo = false;
        }
        if (!string.IsNullOrEmpty(Testo.Text))
        {
            if (espressione.Count == 0)
            {
                espressione.Add(Testo.Text);
                espressione.Add("-");
                Espressione.Text = $"{Testo.Text} - ";
            }
            else
            {
                espressione.Add(Testo.Text);
                string primoElemento = espressione[0];
                string secondoElemento = espressione[1];
                string terzoElemento = espressione[2];
                double risultato = Calcola(primoElemento, secondoElemento, terzoElemento);
                Espressione.Text = $"{risultato} - ";
                espressione.Clear();
                espressione.Add(risultato.ToString());
                espressione.Add("-");
            }
            Testo.Text = "";
        }
    }

    private void Piu(object sender, EventArgs e)
    {
        if (calcolo == true)
        {
            calcolo = false;
        }
        if (!string.IsNullOrEmpty(Testo.Text))
        {
            if (espressione.Count == 0)
            {
                espressione.Add(Testo.Text);
                espressione.Add("+");
                Espressione.Text = $"{Testo.Text} + ";
            }
            else
            {
                espressione.Add(Testo.Text);
                string primoElemento = espressione[0];
                string secondoElemento = espressione[1];
                string terzoElemento = espressione[2];
                double risultato = Calcola(primoElemento, secondoElemento, terzoElemento);
                Espressione.Text = $"{risultato} + ";
                espressione.Clear();
                espressione.Add(risultato.ToString());
                espressione.Add("+");
            }
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
                Testo.Text = "(-" + Testo.Text + ")";
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
    private double Calcola(string primo, string operatore, string secondo)
    {
        double num1 = double.Parse(primo);
        double num2 = double.Parse(secondo);

        // Effettua il calcolo in base all'operatore
        switch (operatore)
        {
            case "+":
                return num1 + num2;
            case "-":
                return num1 - num2;
            case "x":
                return num1 * num2;
            case "÷":
                if (num2 != 0)
                    return num1 / num2;
                else
                {
                    Console.WriteLine("Errore: divisione per zero.");
                    return double.NaN;
                }
            default:
                Console.WriteLine($"Operatore non valido: {operatore}");
                return double.NaN;
        }
    }

    private void Uguale(object sender, EventArgs e)
    {
        if (espressione.Count >= 1)
        {espressione.Add(Testo.Text);
            Espressione.Text += Testo.Text;
            string primoElemento = espressione[0];
            string secondoElemento = espressione[1];
            string terzoElemento = espressione[2];
            double risultato = Calcola(primoElemento, secondoElemento, terzoElemento);
            Testo.Text = risultato.ToString();
            calcolo = true;
        }
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
        DisplayAlert("Contenuto della lista:", popupText.ToString(), "OK");
    }
}
