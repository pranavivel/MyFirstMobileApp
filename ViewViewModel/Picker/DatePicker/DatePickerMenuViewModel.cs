using MyFirstMobileApp._Resources.Models.Titles;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.Picker.DatePicker
{
    public class DatePickerMenuViewModel : BaseViewModel
    {
        public ImageSource BlueButton { get; set; } = Buttons.ButtonDatePickerBlue;
        public ImageSource RedButton { get; set; } = Buttons.ButtonDatePickerRed;
        public ICommand DatePickerXAMLClicked { get; set; }
        public ICommand DatePickerVMClicked { get; set; }

        public DatePickerMenuViewModel()
        {
            Title = TitleDatePicker.DatePickerMenuTitle;

            //Set Button Clicked Event
            DatePickerXAMLClicked = new Command(DatePickerXAMLClickedAsync);
            DatePickerVMClicked = new Command(DatePickerVMClickedAsync);
        }

        private async void DatePickerXAMLClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerXAMLView());
        }

        private async void DatePickerVMClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerVMView());
        }
    }
}
