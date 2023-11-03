using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMobileApp.ViewViewModels.Collections
{
    public class KungFuMoviesCollectionViewModel : BaseViewModel
    {
        // ViewModel: Private fields
        private List<KungFuPandaMovies> _kungfupandamovies;

        // ViewModel: Observable collection bound to the View
        // We use ObservableCollection to automatically update the View when the collection changes.
        public ObservableCollection<KungFuPandaMovies> KungFuCollection { get; }

        public KungFuMoviesCollectionViewModel()
        {
            // ViewModel: Setting the page title for the View
            Title = TitleKPFMoviesCollection.KungFuPandaMoviesTitle;

            // ViewModel: Initialize the ObservableCollection
            KungFuCollection = new ObservableCollection<KungFuPandaMovies>();

            _kungfupandamovies = KungFuPandaMovies.GetMovies();
            this.LoadMovies();
        }

        // ViewModel: Load movies into the ObservableCollection
        private void LoadMovies()
        {
            try
            {
                // Clear the collection in the ViewModel
                KungFuCollection.Clear();

                // Loop through all the movies in the ViewModel collection
                foreach (var p in _kungfupandamovies)
                {
                    // Add the NameofMovie property of the individual movie to the ViewModel collection
                    KungFuCollection.Add(new KungFuPandaMovies { NameofMovie = p.NameofMovie });
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}