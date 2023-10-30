using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstMobileApp.ViewViewModel.Collections.CollectionsMenuViewView
{
    public class CollectionsMenuViewModel
    {
        //Button Commands
        public ICommand OnCollectionViewClicked { get; set; }
        public ICommand OnCollectionWImagesViewClicked { get; set; }
        public ICommand OnCollectionViewButtonsClicked { get; set; }
        public ICommand OnCollectionViewIconClicked { get; set; }

        public CollectionsMenuViewModel()
        {
            Title = Titles.TitleCollectionMenu;

            //Set Commmands
            OnCollectionViewClicked = new Command(OnCollectionViewClickedAsync);
            OnCollectionWImagesViewClicked = new Command(OnCollectionWImagesViewClickedAsync);
            OnCollectionViewButtonsClicked = new Command(OnCollectionViewButtonsClickedAsync);
            OnCollectionViewIconClicked = new Command(OnCollectionViewIconClickedAsync);
        }

        private async void OnCollectionViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new MoviesCollectionView());
        }

        private async void OnCollectionWImagesViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new GOGCollectionWImagesView());
        }

        private async void OnCollectionViewButtonsClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UpdateableCollectionWButtonsView());
        }

        private async void OnCollectionViewIconClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new UpdatableCollectionWIconsView());
        }
    }
}
