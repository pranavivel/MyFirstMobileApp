﻿using MyFirstMobileApp._Resources.Models.Titles;
using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModel.Picker.DatePicker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.Picker.Picker
{
    public class PickerXAMLViewModel : BaseViewModel
    {

        public ImageSource SubmitButton { get; set; } = Buttons.ButtonSubmit;
        public ICommand OnSubmitClicked { get; }
        
        private string _selectedItem = string.Empty;

        public PickerXAMLViewModel()
        {
            //Set Title
            Title = TitlePicker.PickerXAMLTitle;

            //Set Submit Button Command
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value) 
                    SetProperty(ref _selectedItem, value);
            }
        }

        public object TitleSliderPicker { get; }

        private async void OnSubmitClickedAync(object obj)
        {
            //Verify user made a selection
            if (String.IsNullOrEmpty(_selectedItem))
            {
                await Application.Current.MainPage.DisplayAlert(TitlePicker.PickerXAMLTitle, "A selection must be made!", "Ok");
                return;
            }

            List<Cars> cars = Cars.GetCars();

            //Get Selection
            var result = cars.FirstOrDefault(x => x.Car.Equals(_selectedItem));

            await Application.Current.MainPage.Navigation.PushAsync(new PickerResultsView(result.Car, result.Image));
        }

    }

}
