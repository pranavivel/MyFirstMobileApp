using MyFirstMobileApp.ViewViewModel.Collections;

namespace MyFirstMobileApp.ViewViewModels.Collections;

public partial class CollectionMenuView : ContentPage
{
	public CollectionMenuView()
	{
		InitializeComponent();
		BindingContext = new CollectionMenuViewModel();
	}
}