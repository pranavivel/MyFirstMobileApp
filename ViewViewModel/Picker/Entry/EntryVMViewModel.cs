using MyFirstMobileApp._Resources.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.Picker.Entry
{
    public class EntryVMViewModel : BaseViewModel
    {


        public ICommand OnEntryClicked { get; }


        private String _entryText = string.Empty;


        public EntryVMViewModel()
        {
            Title = TitleEntry.EntryVMTitle;
            OnEntryClicked = new Command(OnEntryClickedAsync);
        }


        public string EntryText
        {
            get { return _entryText; }
            set
            {
                if (_entryText != value)
                {
                    SetProperty(ref _entryText, value);
                }
            }
        }


        private async void OnEntryClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(TitleEntry.EntryVMTitle, "Entry can't be empty!", "Ok");
                return;
            }


            await Application.Current.MainPage.Navigation.PushAsync(new EntryResultsView(_entryText));
        }

    }
}
