using MyFirstMobileApp.Models.Entities;
using MyFirstMobileApp.ViewViewModel.CollectionsUpdatable.AddEdit;

namespace MyFirstMobileApp.ViewViewModels.CollectionsUpdatable.AddEdit;

public partial class EditCollectionView : ContentPage
{
	public EditCollectionView(MarvelMovies marvel)
	{
		InitializeComponent();
		BindingContext = new EditCollectionViewModel();
		MovieTitle.Text = marvel.NameofMovie;
	}
}