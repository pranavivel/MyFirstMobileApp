using MyFirstMobileApp.ViewViewModel.CollectionsUpdatable;

namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable;

public partial class UpdateableCollectionWButtonsView : ContentPage
{
	public UpdateableCollectionWButtonsView()
	{
		InitializeComponent();
		BindingContext = new UpdateableCollectionViewModel();
	}
}