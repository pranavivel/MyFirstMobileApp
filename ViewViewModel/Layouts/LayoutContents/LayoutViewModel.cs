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


    //Commands
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
