using MyFirstMobileApp.Models.Titles;
using MyFirstMobileApp.ViewViewModel.Collections.CollectionsView;
using MyFirstMobileApp.ViewViewModel.Collections.ImagesView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.Collections.CollectionsMenuViewView
{
    public class CollectionsMenuViewModel : ContentView
    {

        public String CollectionsMenuTitle { get; set; } = TitleCollectionMenu.TitleCollection;
        public String KFPImagesTitle { get; set; } = TitleCollectionMenu.TitleKFPImages;

        //Button Commands
        public ICommand OnCollectionViewClicked { get; set; }
        public ICommand OnKFPCollectionWImagesViewClicked { get; set; }
        //public ICommand OnCollectionViewButtonsClicked { get; set; }
        //public ICommand OnCollectionViewIconClicked { get; set; }

        public CollectionsMenuViewModel()
        {

            //Set Commmands
            OnCollectionViewClicked = new Command(OnCollectionViewClickedAsync);
            OnKFPCollectionWImagesViewClicked = new Command(OnKFPCollectionWImagesViewClickedAsync);
            //OnCollectionViewButtonsClicked = new Command(OnCollectionViewButtonsClickedAsync);
            //OnCollectionViewIconClicked = new Command(OnCollectionViewIconClickedAsync);
        }

        private async void OnCollectionViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CollectionsMenuView());
        }

        private async void OnKFPCollectionWImagesViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new KFPCollectionWImagesView());
        }

        
    }
}
