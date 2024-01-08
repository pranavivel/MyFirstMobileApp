using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModel.AppImages.ImagesMenuContents;
using MyFirstMobileApp.ViewViewModel.Layouts.LayoutContents;
using System.Windows.Input;
using MyFirstMobileApp.ViewViewModels.Collections;
using MyFirstMobileApp._Resources.Models.Titles;
using MyFirstMobileApp.ViewViewModel.InteractiveControls.Stepper;

namespace MyFirstMobileApp.ViewViewModel.Main;

public class MainViewModel : BaseViewModel
{
    public String LayoutTitle { get; set; } = TitleMain.TitleLayout;
    public String ImagesTitle { get; set; } = TitleMain.TitleImages;
    public String CollectionTitle { get; set; } = TitleMain.TitleCollections;
    public String ControlsTitle { get; set; } = TitleMain.TitleControls;
    //public String SQLiteTitle { get; set; } = TitleMain.TitleSQLite;

    public string Layouts { get; set; } 

	public ICommand OnLayoutsClicked { get; set; }
    public ICommand OnImagesClicked { get; set; }
    public ICommand OnCollectionsClicked { get; set; }
    public ICommand OnControlsClicked { get; set; }



    public MainViewModel()
	{
		Title = TitleMain.appTitle;

		OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        OnImagesClicked = new Command(OnImagesClickedAsync);
        OnCollectionsClicked = new Command(OnCollectionsClickedAsync);
        OnControlsClicked = new Command(OnControlsClickedAsync);
        

    }

	private async void OnLayoutsClickedAsync()
	{
        await Application.Current.MainPage.Navigation.PushAsync(new LayoutView());
    }

    private async void OnImagesClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ImagesMenuView());
    }

    private async void OnCollectionsClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new CollectionMenuView());
    }

    private async void OnControlsClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StepperView());
    }

}