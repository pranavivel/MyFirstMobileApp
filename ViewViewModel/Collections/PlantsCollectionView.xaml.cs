using MyFirstMobileApp.ViewViewModel.Collections;

namespace MyFirstMobileApp.ViewViewModels.Collections;

public partial class MoviesCollectionView : ContentPage
{
	public MoviesCollectionView()
	{
		InitializeComponent();
		BindingContext = new PlantsCollectionViewModel();
	}
}