using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.CollectionsUpdatable
{
    public class UpdateableCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<PlantsSpecies> PlantsCollection { get; set; }

        public UpdateableCollectionViewModel()
        {
            //Set the title for this view
            Title = TitleCollections.CollectionTitle;

            //Create a new ObservableCollection to store movies
            PlantsCollection = new ObservableCollection<PlantsSpecies>();

            //Load movies from the data source
            LoadPlants();
        }

        //Method to load movies from a data source
        private void LoadPlants()
        {
            IsBusy = true;

            try
            {
                //Clear the existing collection
                PlantsCollection.Clear();

                //Get a list of Marvel movies and add them to the collection
                var flowerPlants = PlantsSpecies.GetPlants();
                foreach (var plant in flowerPlants)
                {
                    PlantsCollection.Add(plant);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

#pragma warning disable CA1416 // Validate platform compatibility
        //Command to add a new plant
        public ICommand AddCommand => new Command(async () =>
        {
            //Navigate to the AddCollectionView when the "Add" button is clicked

            await Application.Current.MainPage.Navigation.PushAsync(new AddCollectionView());

            //****************************************************************************************
            // A messaging event is a way for different parts of your app to communicate.
            // It's like a message sent from one part to another to share data or trigger actions.
            // MessagingCenter helps subscribe to and send these events.
            // In this code, when you add a movie in AddCollectionView, it sends an "AddMovies" event.
            // UpdateableCollectionWButtonsViewModel listens for this event and updates the movie list.
            //****************************************************************************************
            //Subscribe to the "AddMovies" messaging event to receive updated data from AddCollectionView            
            MessagingCenter.Subscribe<PlantsSpecies>(this, "AddPlants", async (plant) =>
            {
                //Add the new movie data to the collection
                PlantsCollection.Add(plant);

                //Unsubscribe from the messaging event
                MessagingCenter.Unsubscribe<PlantsSpecies>(this, "AddPlants");
            });
        });

        //Command to update a movie
        public ICommand UpdateCommand => new Command<PlantsSpecies>(async plant =>
        {
            //Get the index of the selected movie in the collection
            var index = PlantsCollection.IndexOf(plant);

            //Navigate to the EditCollectionView to edit the selected plant when the Update Button is Clicked
            await Application.Current.MainPage.Navigation.PushAsync(new EditCollectionView(plant));

            //****************************************************************************************
            // A messaging event is a way for different parts of your app to communicate.
            // It's like a message sent from one part to another to share data or trigger actions.
            // MessagingCenter helps subscribe to and send these events.
            // In this code, when you update a movie in EditCollectionView, it sends an "UpdateMovies" event.
            // UpdateableCollectionWButtonsViewModel listens for this event and updates the movie list.
            //****************************************************************************************
            //Subscribe to the "UpdateMovies" messaging event to receive updated data from EditCollectionView            
            MessagingCenter.Subscribe<PlantsSpecies>(this, "UpdateMovies", updatedPlant =>
            {
                //Update the movie in the collection with the edited data
                PlantsCollection[index] = updatedPlant;
            });
        });

        //Command to delete a movie
        public ICommand DeleteCommand => new Command<PlantsSpecies>(plant =>
        {
            //Remove the selected movie from the collection
            PlantsCollection.Remove(plant);
        });
#pragma warning restore CA1416 // Validate platform compatibility

    }
}
