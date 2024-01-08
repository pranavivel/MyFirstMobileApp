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
    public class DatePickerVMViewModel : BaseViewModel
    {
        public ImageSource SubmitButton { get; } = Buttons.ButtonSubmit;

        public ICommand SubmitCommand => new Command(OnSubmit);

        private DateTime _startDate;
        private DateTime _minStartDate;
        private DateTime _endDate;
        private DateTime _maxEndDate;

        public DatePickerVMViewModel()
        {
            Title = TitleDatePicker.DatePickerVMTitle;

            //Set initial values
            StartDate = new DateTime(DateTime.Now.Year, 1, 1);
            MinStartDate = new DateTime(DateTime.Now.Year, 1, 1);
            EndDate = new DateTime(DateTime.Now.Year, 12, 31);
            MaxEndDate = new DateTime(DateTime.Now.Year, 12, 31);
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { SetProperty(ref _startDate, value); }
        }

        public DateTime MinStartDate
        {
            get { return _minStartDate; }
            set { SetProperty(ref _minStartDate, value); }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { SetProperty(ref _endDate, value); }
        }

        public DateTime MaxEndDate
        {
            get { return _maxEndDate; }
            set { SetProperty(ref _maxEndDate, value); }
        }

        private async void OnSubmit()
        {
            string msg = string.Empty;

            if (StartDate.ToShortDateString() == MinStartDate.ToShortDateString() &&
                EndDate.ToShortDateString() == MaxEndDate.ToShortDateString())
            {
                msg = "The dates were not changed! \n\n" +
                          "Start Date: " + MinStartDate.ToShortDateString() + "\n" +
                          "End Date: " + MaxEndDate.ToShortDateString();
            }
            else
            {
                msg = "The dates were changed! \n\n" +
                          "Original start date selected was: " + MinStartDate.ToShortDateString() + "\n " +
                          "Original end date selected was: " + MaxEndDate.ToShortDateString() + "\n\n" +
                          "New start date selected is: " + StartDate.ToShortDateString() + "\n " +
                          "New end date selected is: " + EndDate.ToShortDateString();
            }

            await Application.Current.MainPage.DisplayAlert(TitleDatePicker.DatePickerVMTitle, msg, "Ok");
        }
    }
}
