using MyFirstMobileApp.ViewViewModel.CollectionsUpdatable.AddEdit;

namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;

public partial class AddCollectionView : ContentPage
{
	public AddCollectionView()
	{
		InitializeComponent();
		BindingContext = new AddCollectionViewModel();
	}
}