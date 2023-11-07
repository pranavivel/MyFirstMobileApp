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
        private List<Plants> _plants;

        // ViewModel: Observable collection bound to the View
        // We use ObservableCollection to automatically update the View when the collection changes.
        public ObservableCollection<Plants> PlantsCollection { get; }

        public PlantsCollectionViewModel()
        {
            // ViewModel: Setting the page title for the View
            Title = TitleMarvelMoviesCollection.MarvelMoviesTitle;

            // ViewModel: Initialize the ObservableCollection
            PlantsCollection = new ObservableCollection<Plants>();

            _plants = Plants.GetMovies();
            LoadMovies();
        }

        // ViewModel: Load movies into the ObservableCollection
        private void LoadMovies()
        {
            try
            {
                // Clear the collection in the ViewModel
                PlantsCollection.Clear();

                // Loop through all the movies in the ViewModel collection
                foreach (var p in _plants)
                {
                    // Add the NameofMovie property of the individual movie to the ViewModel collection
                    PlantsCollection.Add(new Plants { NameofPlant = p.NameofPlant });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
