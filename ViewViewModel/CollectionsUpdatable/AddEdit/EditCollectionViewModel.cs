using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Models.Utilities;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;

#pragma warning disable CA1416 // Validate platform compatibility
namespace MyFirstMobileApp.ViewViewModel.CollectionsUpdatable.AddEdit
{
    public class EditCollectionViewModel : BaseViewModel
    {
        public ICommand UpdateBtnClicked { get; set; }
        private string _movieName = string.Empty;

        public EditCollectionViewModel()
        {
            Title = TitlesMisc.EditTitle;
            UpdateBtnClicked = new Command(PerformSave);
        }

        public string MovieName
        {
            get { return _movieName; }

            set
            {
                if (_movieName != value)
                    // Use the SetProperty method to update the private field _movies
                    // and trigger property change notifications when the Movies property value changes.
                    SetProperty(ref _movieName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_movieName.Trim()))
            {
                // Use Page.DisplayAlert to display the alert
                Application.Current.MainPage.DisplayAlert(TitlesMisc.EditTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            MarvelMovies movies = new MarvelMovies();
            movies.NameofMovie = _movieName;

            MessagingCenter.Send<MarvelMovies>(movies, "UpdateMovies");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
