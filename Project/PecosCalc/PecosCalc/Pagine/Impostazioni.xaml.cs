using Microsoft.Maui.Controls;

namespace PecosCalc.Pagine
{
    public partial class Impostazioni : ContentPage
    {
        public Impostazioni()
        {
            InitializeComponent();

            switchScuro.IsToggled = true;
        }

        private void Switching(object sender, ToggledEventArgs e)
        {
            Switch switcher = (Switch)sender;

            if (e.Value)
            {
                if (switcher == switchScuro)
                {
                    // Impostazioni per il tema scuro
                    Resources["fgColor"] = Colors.White;
                    Resources["bgColor"] = Colors.Black;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.White);
                    ((App)App.Current).Tema = "Nero";
                    switchScuro.IsToggled = true;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchChiaro)
                {
                    // Impostazioni per il tema chiaro
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.White;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.White);
                    ((App)App.Current).Tema = "Bianco";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = true;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchRosso)
                {
                    // Impostazioni per il tema rosso
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.Red;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.Red);
                    ((App)App.Current).Tema = "Rosso";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = true;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchBlu)
                {
                    // Impostazioni per il tema blu
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.CornflowerBlue;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.CornflowerBlue);
                    ((App)App.Current).Tema = "Blu";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = true;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchRosa)
                {
                    // Impostazioni per il tema rosa
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.Pink;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.Pink);
                    ((App)App.Current).Tema = "Rosa";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = true;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchGiallo)
                {
                    // Impostazioni per il tema giallo
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.Yellow;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.Yellow);
                    ((App)App.Current).Tema = "Giallo";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = true;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchVerde)
                {
                    // Impostazioni per il tema verde
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.Green;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.Green);
                    ((App)App.Current).Tema = "Verde";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = true;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchViola)
                {
                    // Impostazioni per il tema viola
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.MediumPurple;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.MediumPurple);
                    ((App)App.Current).Tema = "Viola";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = true;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchOro)
                {
                    // Impostazioni per il tema oro
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.Gold;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.Gold);
                    ((App)App.Current).Tema = "Oro";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = true;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;

                }
                else if (switcher == switchArancione)
                {
                    // Impostazioni per il tema arancione
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.Orange;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.Orange);
                    ((App)App.Current).Tema = "Arancione";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = true;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchMarrone)
                {
                    // Impostazioni per il tema marrone
                    Resources["fgColor"] = Colors.Black;
                    Resources["bgColor"] = Colors.Brown;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.Brown);
                    ((App)App.Current).Tema = "Marrone";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = true;
                    switchAzzurro.IsToggled = false;
                }
                else if (switcher == switchAzzurro)
                {
                    // Impostazioni per il tema marrone
                    Resources["fgColor"] = Colors.White;
                    Resources["bgColor"] = Colors.LightSkyBlue;
                    AppShell.SetBackgroundColor(this, Colors.Black);
                    AppShell.SetTitleColor(this, Colors.LightSkyBlue);
                    ((App)App.Current).Tema = "Azzurro";
                    switchScuro.IsToggled = false;
                    switchChiaro.IsToggled = false;
                    switchRosso.IsToggled = false;
                    switchBlu.IsToggled = false;
                    switchRosa.IsToggled = false;
                    switchGiallo.IsToggled = false;
                    switchVerde.IsToggled = false;
                    switchViola.IsToggled = false;
                    switchOro.IsToggled = false;
                    switchArancione.IsToggled = false;
                    switchMarrone.IsToggled = false;
                    switchAzzurro.IsToggled = true;

                }
            }
            #region ControlloStatoSwitch
            if (((App)App.Current).Tema == "Nero")
                switchScuro.IsToggled = true;
            if (((App)App.Current).Tema == "Bianco")
                switchChiaro.IsToggled = true;
            if (((App)App.Current).Tema == "Rosso")
                switchRosso.IsToggled = true;
            if (((App)App.Current).Tema == "Blu")
                switchBlu.IsToggled = true;
            if (((App)App.Current).Tema == "Rosa")
                switchRosa.IsToggled = true;
            if (((App)App.Current).Tema == "Giallo")
                switchGiallo.IsToggled = true;
            if (((App)App.Current).Tema == "Verde")
                switchVerde.IsToggled = true;
            if (((App)App.Current).Tema == "Viola")
                switchViola.IsToggled = true;
            if (((App)App.Current).Tema == "Oro")
                switchOro.IsToggled = true;
            if (((App)App.Current).Tema == "Arancione")
                switchArancione.IsToggled = true;
            if (((App)App.Current).Tema == "Marrone")
                switchMarrone.IsToggled = true;
            if (((App)App.Current).Tema == "Azzurro")
                switchAzzurro.IsToggled = true;
            #endregion
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
}
