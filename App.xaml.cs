using MyFirstMobileApp.ViewViewModel.Main;

namespace MyFirstMobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainView());
        }
    }
}