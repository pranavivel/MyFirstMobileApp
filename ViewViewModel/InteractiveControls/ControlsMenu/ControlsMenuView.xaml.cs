namespace MyFirstMobileApp.ViewViewModel.InteractiveControls.ControlsMenu;

public partial class ControlsMenuView : ContentPage
{
	public ControlsMenuView()
	{
		InitializeComponent();
        BindingContext = new ControlsMenuViewModel();
    }
}