using MyFirstMobileApp._Resources.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModel.InteractiveControls.Stepper;
using MyFirstMobileApp.ViewViewModel.Picker.DatePicker;
using MyFirstMobileApp.ViewViewModel.Picker.Entry;
using MyFirstMobileApp.ViewViewModel.Picker.Picker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.InteractiveControls.ControlsMenu
{
    public class ControlsMenuViewModel : BaseViewModel
    {
        //public String SliderTitle { get; set; } = TitleControlsMenu.TitleSlider;
        //public String StepperTitle { get; set; } = TitleControlsMenu.TitleStepper;
        //public String SwitchTitle { get; set; } = TitleControlsMenu.TitleSwitch;
        public String EntryTitle { get; set; } = TitleControlsMenu.TitleEntry;
        public String PickerTitle { get; set; } = TitleControlsMenu.TitlePicker;
        public String DateAndTimePickerTitle { get; set; } = TitleControlsMenu.TitleDateAndTimePicker;

        public String Layouts { get; set; }

        //public ICommand OnSliderClicked { get; set; }
        //public ICommand OnStepperClicked { get; set; }
        //public ICommand OnSwitchClicked { get; set; }
        public ICommand OnEntryClicked { get; set; }
        public ICommand OnPickerClicked { get; set; }
        public ICommand OnDateAndTimeClicked { get; set; }
        public ICommand OnSubmitClicked { get; set; }


        public ControlsMenuViewModel()
        {
            //OnSliderClicked = new Command(onSliderClickedAsync);
            //OnStepperClicked = new Command(onStepperClickedAsync);
            //OnSwitchClicked = new Command(onSwitchClickedAsync);
            OnEntryClicked = new Command(onEntryClickedAsync);
            OnPickerClicked = new Command(onPickerClickedAsync);
            OnDateAndTimeClicked = new Command(onDateAndTimePickerClickedAsync);
            OnSubmitClicked = new Command(OnSubmitClickedAsync);
        }

        //private async void onSliderClickedAsync()
        //{
        //await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        //}
        //private async void onStepperClickedAsync()
        //{
        //await Application.Current.MainPage.Navigation.PushAsync(new StepperView());
        //}

        //private async void onSwitchClickedAsync()
        //{
        //await Application.Current.MainPage.Navigation.PushAsync(new SwitchView());
        //}
        private async void onEntryClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new EntryXAMLView());
        }
        private async void onPickerClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerXAMLView());
        }
        private async void onDateAndTimePickerClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DatePickerMenuView());
        }

        private async void OnSubmitClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PickerXAMLView());
        }
    }
}
