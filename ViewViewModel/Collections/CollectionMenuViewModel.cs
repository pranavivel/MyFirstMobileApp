using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModel.CollectionsUpdatable;
using MyFirstMobileApp.ViewViewModels.Collections;
using MyFirstMobileApp.ViewViewModels.CollectionsUpdatable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.Collections
{
    public class CollectionMenuViewModel : BaseViewModel
    {
        //Button Commands
        public ICommand OnCollectionViewClicked { get; set; }
        public ICommand OnCollectionWImagesViewClicked { get; set; }
        public ICommand OnCollectionViewButtonsClicked { get; set; }
        public ICommand OnCollectionViewIconClicked { get; set; }

        public CollectionMenuViewModel()
        {
            Title = TitleCollectionMenu.CollectionTitle;

            //Set Commmands
            OnCollectionViewClicked = new Command(OnCollectionViewClickedAsync);
            OnCollectionWImagesViewClicked = new Command(OnCollectionWImagesViewClickedAsync);
            OnCollectionViewButtonsClicked = new Command(OnCollectionViewButtonsClickedAsync);
            OnCollectionViewIconClicked = new Command(OnCollectionViewIconClickedAsync);
        }

        private async void OnCollectionViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new PlantsCollectionView());
        }

        private async void OnCollectionWImagesViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FlowersCollectionWImagesView());
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
