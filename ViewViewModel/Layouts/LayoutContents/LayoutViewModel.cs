using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewViewModel.Layouts.StackLayoutContents;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.Layouts.LayoutContents;

public class LayoutViewModel : ContentView
{

    //Text Titles
    public string TitleStackLayout { get; set; } = TitleLayout.StackLayoutTitle;
    public string TitleVerticalStack { get; set; } = TitleLayout.VerticalStackTitle;
    public string TitleHorizontalStack { get; set; } = TitleLayout.HorizontalStackTitle;
    public string TitleAbsolutestack { get; set; } = TitleLayout.AbsoluteLayoutTitle;
    public string TitleFlexStack { get; set; } = TitleLayout.FlexLayoutTitle;


    //Commands
    public ICommand OnLayoutsClicked { get; set; }
    public ICommand OnVerticalClicked { get; set; }
    public ICommand OnHorizontalClicked { get; set; }
    public ICommand OnAbsoluteClicked { get; set; }

    public LayoutViewModel()
    {
        OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
        OnVerticalClicked = new Command(OnVerticalClickedAsync);
        OnHorizontalClicked = new Command(OnHorizontalClickedAsync);
        OnAbsoluteClicked = new Command(OnAbsoluteClickedAsync);
    }

    private async void OnLayoutsClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
    }

    private async void OnVerticalClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
    }

    private async void OnHorizontalClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
    }

    private async void OnAbsoluteClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
    }

    private async void OnFlexClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
    }


}
