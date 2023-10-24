
using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;

namespace MyFirstMobileApp.ViewViewModel.AppImages.EmbeddedContents
{
    public class EmbeddedViewModel : BaseViewModel
    {
        public EmbeddedViewModel()
        {
            Title = TitleEmbedded.EmbImageTitle;
        }

        public ImageSource GetImageSource
        {
            get
            {
                return ImageSource.FromFile("Images/food.jpg");
            }
        }

    }
}
