using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.Models.Utilities;
using MyFirstMobileApp.ViewModels;
using System.Windows.Input;

#pragma warning disable CA1416 // Validate platform compatibility
namespace MyFirstMobileApp.ViewViewModel.CollectionsUpdatable.AddEdit
{
    public class AddCollectionViewModel : BaseViewModel
    {
        public ICommand SaveBtnClicked { get; set; }
        private string _plantName = string.Empty;

        public AddCollectionViewModel()
        {
            Title = TitlesMisc.AddTitle;
            SaveBtnClicked = new Command(PerformSave);
        }

        public string PlantName
        {
            get { return _plantName; }

            set
            {
                if (_plantName != value)
                    SetProperty(ref _plantName, value);
            }
        }

        private void PerformSave()
        {
            if (string.IsNullOrEmpty(_plantName.Trim()))
            {
                // Use Page.DisplayAlert to display the alert
                Application.Current.MainPage.DisplayAlert(TitlesMisc.AddTitle, Msgs.NotEmpty, "Ok");
                return;
            }

            PlantsSpecies plants = new PlantsSpecies();
            plants.NameofPlant = _plantName;

            MessagingCenter.Send<PlantsSpecies>(plants, "AddPlants");

            if (Application.Current.MainPage is NavigationPage navigationPage)
            {
                navigationPage.Navigation.PopAsync();
            }
        }
    }
}
#pragma warning restore CA1416 // Validate platform compatibility
