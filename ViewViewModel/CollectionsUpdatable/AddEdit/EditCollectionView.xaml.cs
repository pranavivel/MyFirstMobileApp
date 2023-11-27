using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewViewModel.CollectionsUpdatable.AddEdit;

namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;

public partial class EditCollectionView : ContentPage
{
    private PlantsSpecies plant;

    public EditCollectionView(PlantsSpecies plant)
	{
		InitializeComponent();
		BindingContext = new EditCollectionViewModel();
		PlantTitle.Text = plant.NameofPlant;
	}
}