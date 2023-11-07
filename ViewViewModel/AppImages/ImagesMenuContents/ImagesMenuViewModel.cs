using MyFirstMobileApp._Resources.Models.Titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.AppImages.ImagesMenuContents
{
    class ImagesMenuViewModel
    {
        public String EmbeddedTitle { get; set; } = TitleImages.TitleEmbedded;

        public string AppImages { get; set; }

        public ICommand OnEmbeddedClicked { get; set; }

        public ImagesMenuViewModel()
        {

            OnEmbeddedClicked = new Command(OnEmbeddedClickedAsync);

        }

        private async void OnEmbeddedClickedAsync()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ImagesMenuView());
        }

    }
}
