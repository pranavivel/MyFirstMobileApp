
namespace MyFirstMobileApp.ViewViewModel.Picker.Picker;

public partial class PickerXAMLView : ContentPage
{


    public PickerXAMLView()
    {
        InitializeComponent();
        BindingContext = new PickerXAMLViewModel();
    }
}
