namespace PecosCalc
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (((App)App.Current).Tema == "Nero")
            {
                Resources["fgColor"] = Colors.White;
                Resources["bgColor"] = Colors.Black;
            }
            else if (((App)App.Current).Tema == "Bianco")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.White;
            }
            else if (((App)App.Current).Tema == "Rosso")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.Red;
            }
            else if (((App)App.Current).Tema == "Blu")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.Blue;
            }
            else if (((App)App.Current).Tema == "Rosa")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.Pink;
            }
            else if (((App)App.Current).Tema == "Giallo")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.Yellow;
            }
            else if (((App)App.Current).Tema == "Verde")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.Green;
            }
            else if (((App)App.Current).Tema == "Viola")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.MediumPurple;
            }
            else if (((App)App.Current).Tema == "Oro")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.Gold;
            }
            else if (((App)App.Current).Tema == "Arancione")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.Orange;
            }
            else if (((App)App.Current).Tema == "Marrone")
            {
                Resources["fgColor"] = Colors.Black;
                Resources["bgColor"] = Colors.Brown;
            }
        }
    }
}
