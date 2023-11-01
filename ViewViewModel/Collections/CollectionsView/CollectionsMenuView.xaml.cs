using MyFirstMobileApp.ViewViewModel.Collections.CollectionsMenuViewView;

namespace MyFirstMobileApp.ViewViewModel.Collections.CollectionsView;

public partial class CollectionsMenuView : ContentPage
{
	public CollectionsMenuView()
	{
		InitializeComponent();
        BindingContext = new CollectionsMenuViewModel();
    }
}