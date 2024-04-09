namespace PecosCalc
{
    public partial class App : Application
    {
        public string Tema { get; set; }
        public List<string> scientifica {  get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            Tema = "Nero";
            scientifica = new List<string>();
        }
    }
}