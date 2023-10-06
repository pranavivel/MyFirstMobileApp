using MyFirstMobileApp.Models;
using MyFirstMobileApp.ViewViewModel.Layouts.StackLayoutContents;
using System.Windows.Input;

namespace MyFirstMobileApp.ViewViewModel.Layouts.LayoutContents;

public class LayoutViewModel : ContentView
{

    //The data from TitleLayouts
    public string TitleStackLayout { get; set; } = TitleLayout.StackLayoutTitle;
    public string BtnVerticalStack { get; set; } = TitleLayout.VerticalStackTitle;
    public string BtnHorizontalStack { get; set; } = TitleLayout.HorizontalStackTitle;
    public string BtnAbsoluteLayout { get; set; } = TitleLayout.AbsoluteLayoutTitle;

    public string Layouts { get; set; }

    public ICommand OnLayoutsClicked { get; set; }

    public LayoutViewModel()
    {
        OnLayoutsClicked = new Command(OnLayoutsClickedAsync);
    }

    private async void OnLayoutsClickedAsync()
    {
        await Application.Current.MainPage.Navigation.PushAsync(new StackLayoutView());
    }
}
