using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewModels;
using MyFirstMobileApp.ViewViewModel.AppImages.ImagesMenuContents;
using MyFirstMobileApp.ViewViewModel.Layouts.LayoutContents;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.Main;

public class MainViewModel : BaseViewModel
{
    public String LayoutTitle { get; set; } = TitleMain.TitleLayout;
    public String ImagesTitle { get; set; } = TitleMain.TitleImages;
    public String Button10Title { get; set; } = TitleMain.TitleButton10;
    public String Button11Title { get; set; } = TitleMain.TitleButton11;

    public string Layouts { get; set; } 

	public ICommand OnLayoutsClicked { get; set; }
    public ICommand OnImagesClicked { get; set; }



    public MainViewModel()
	{
		Title = TitleMain.appTitle;

		OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        OnImagesClicked = new Command(OnImagesClickedAsync);

    }

	private async void OnLayoutsClickedAsync()
	{
        await Application.Current.MainPage.Navigation.PushAsync(new LayoutView());
    }

    private async void OnImagesClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new ImagesMenuView());
    }
}