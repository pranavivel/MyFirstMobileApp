using MyFirstMobileApp.ViewViewModel.Collections;

namespace MyFirstMobileApp.ViewViewModels.Collections;

public partial class GOGCollectionWImagesView : ContentPage
{
	public GOGCollectionWImagesView()
	{
		InitializeComponent();
		BindingContext = new FlowersCollectionWImagesViewModel();
	}
}