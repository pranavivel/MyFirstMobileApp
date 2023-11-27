using MyFirstMobileApp.ViewViewModel.Collections;

namespace MyFirstMobileApp.ViewViewModels.Collections;

public partial class FlowersCollectionWImagesView : ContentPage
{
	public FlowersCollectionWImagesView()
	{
		InitializeComponent();
		BindingContext = new FlowersCollectionWImagesViewModel();
	}
}