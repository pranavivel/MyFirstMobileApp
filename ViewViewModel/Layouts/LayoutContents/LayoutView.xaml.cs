
namespace MyFirstMobileApp.ViewViewModel.Layouts.LayoutContents;

public partial class LayoutView : ContentPage
{
	public LayoutView()
	{
        //Add binding and create LayoutView page
        InitializeComponent();
        BindingContext = new LayoutViewModel();
    }
}