namespace MyFirstMobileApp.ViewViewModel.Picker.DatePicker;

public partial class DatePickerVMView : ContentPage
{
    public DatePickerVMView()
    {
        InitializeComponent();
        BindingContext = new DatePickerVMViewModel();
    }
}