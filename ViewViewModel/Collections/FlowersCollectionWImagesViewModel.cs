using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMobileApp.ViewViewModel.Collections
{
    public class FlowersCollectionWImagesViewModel : BaseViewModel
    {
        public ObservableCollection<FlowerSpeciesInfo> FlowersCollection { get; }

        private List<FlowerSpeciesInfo> _flowers;

        public FlowersCollectionWImagesViewModel()
        {
            Title = TitleCollectionWImages.CollectionWImagesTitle;

            //Instantiate Obervable GuardiansCollection
            FlowersCollection = new ObservableCollection<FlowerSpeciesInfo>();
            _flowers = FlowerSpeciesInfo.GetSampleFlowerData();
            LoadPlants();
        }

        private void LoadPlants()
        {
            try
            {
                FlowersCollection.Clear();
                foreach (var g in _flowers)
                {
                    FlowersCollection.Add(g);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
