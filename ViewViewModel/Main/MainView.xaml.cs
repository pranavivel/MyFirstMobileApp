namespace MyFirstMobileApp.ViewViewModel.Main;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();

	}
}