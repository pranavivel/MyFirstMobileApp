using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMobileApp.ViewViewModel.Collections
{
    public class PlantsCollectionViewModel : BaseViewModel
    {
        // ViewModel: Private fields
        private List<PlantsSpecies> _plants;

        // ViewModel: Observable collection bound to the View
        // We use ObservableCollection to automatically update the View when the collection changes.
        public ObservableCollection<PlantsSpecies> PlantsCollection { get; }

        public PlantsCollectionViewModel()
        {
            // ViewModel: Setting the page title for the View
            Title = TitlePlantsCollection.PlantsTitle;

            // ViewModel: Initialize the ObservableCollection
            PlantsCollection = new ObservableCollection<PlantsSpecies>();

            _plants = PlantsSpecies.GetPlants();
            LoadPlants();
        }

        // ViewModel: Load plants into the ObservableCollection
        private void LoadPlants()
        {
            try
            {
                // Clear the collection in the ViewModel
                PlantsCollection.Clear();

                // Loop through all the plants in the ViewModel collection
                foreach (var p in _plants)
                {
                    // Add the NameofPlant property of the individual plants to the ViewModel collection
                    PlantsCollection.Add(new PlantsSpecies { NameofPlant = p.NameofPlant });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
