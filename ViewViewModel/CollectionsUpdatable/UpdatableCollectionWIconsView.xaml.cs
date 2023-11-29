namespace MyFirstMobileApp.ViewViewModel.CollectionsUpdatable;

public partial class UpdatableCollectionWIconsView : ContentPage
{
	public UpdatableCollectionWIconsView()
	{
		InitializeComponent();
        BindingContext = new UpdateableCollectionViewModel();
    }
}