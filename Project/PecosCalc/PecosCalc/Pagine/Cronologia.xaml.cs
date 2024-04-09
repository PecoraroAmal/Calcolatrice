using System.Collections.ObjectModel;
using System.ComponentModel;

namespace PecosCalc.Pagine
{
    public partial class Cronologia : ContentPage
    {
        private CronologiaViewModel _viewModel;

        public Cronologia()
        {
            InitializeComponent();
            _viewModel = new CronologiaViewModel();
            BindingContext = _viewModel;
        }

        private void Clear(object sender, EventArgs e)
        {
            DisplayAlert("Informazione","Cronologia eliminata", "OK");
            _viewModel.Clear();
            ((App)App.Current).scientifica.Clear();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.CaricaListaScientifica();
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

    public class CronologiaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<string> _scientificItems;
        public ObservableCollection<string> ScientificItems
        {
            get { return _scientificItems; }
            set
            {
                _scientificItems = value;
                OnPropertyChanged(nameof(ScientificItems));
            }
        }

        public CronologiaViewModel()
        {
            _scientificItems = new ObservableCollection<string>();
            CaricaListaScientifica();
        }

        public void Clear()
        {
            ScientificItems.Clear();
        }

        public void CaricaListaScientifica()
        {
            ScientificItems.Clear();
            foreach (string elemento in ((App)App.Current).scientifica)
            {
                ScientificItems.Add(elemento);
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
