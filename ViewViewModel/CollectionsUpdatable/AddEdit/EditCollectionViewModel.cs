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
        private string _plantName = string.Empty;

        public EditCollectionViewModel()
        {
            Title = TitlesMisc.EditTitle;
            UpdateBtnClicked = new Command(PerformSave);
        }

        public string Plant
        {
            get { return _plantName; }

            set
            {
                if (_plantName != value)
                    // Use the SetProperty method to update the private field _plants
                    // and trigger property change notifications when the Plants property value changes.
                    SetProperty(ref _plantName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_plantName.Trim()))
            {
                // Use Page.DisplayAlert to display the alert
                Application.Current.MainPage.DisplayAlert(TitlesMisc.EditTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            PlantsSpecies plants = new PlantsSpecies();
            plants.NameofPlant = _plantName;

            MessagingCenter.Send<PlantsSpecies>(plants, "UpdatePlants");
            Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
