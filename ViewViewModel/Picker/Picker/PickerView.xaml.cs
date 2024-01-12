namespace MyFirstMobileApp.ViewViewModel.Picker.Picker;

public partial class PickerView : ContentPage
{
	public PickerView()
	{
		InitializeComponent();
        BindingContext = new PickerViewModel();
    }
}