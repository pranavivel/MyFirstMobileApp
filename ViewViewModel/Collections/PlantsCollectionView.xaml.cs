using MyFirstMobileApp.ViewViewModel.Collections;
using MyFirstMobileApp.ViewViewModels.Collections;

namespace MyFirstMobileApp.ViewViewModels.Collections;

public partial class PlantsCollectionView : ContentPage
{ 
    public PlantsCollectionView()
	{
        InitializeComponent();
		BindingContext = new PlantsCollectionViewModel();
	}
}