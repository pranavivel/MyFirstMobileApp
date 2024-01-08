namespace MyFirstMobileApp.ViewViewModel.Picker.DatePicker;


public partial class DatePickerMenuView : ContentPage
{
    public DatePickerMenuView()
    {
        InitializeComponent();
        BindingContext = new DatePickerMenuViewModel();
    }
}


