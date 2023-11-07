using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MyFirstMobileApp.ViewViewModel.Collections
{
    public class FlowersCollectionWImagesViewModel : BaseViewModel
    {
        public ObservableCollection<ActorCharacterInfo> GuardiansCollection { get; }

        private List<ActorCharacterInfo> _guardians;

        public FlowersCollectionWImagesViewModel()
        {
            Title = TitleCollectionWImages.CollectionWImagesTitle;

            //Instantiate Obervable GuardiansCollection
            GuardiansCollection = new ObservableCollection<ActorCharacterInfo>();
            _guardians = ActorCharacterInfo.GetSampleCharacterData();
            LoadGuardians();
        }

        private void LoadGuardians()
        {
            try
            {
                GuardiansCollection.Clear();
                foreach (var g in _guardians)
                {
                    GuardiansCollection.Add(g);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
