using MyFirstMobileApp.Models;

namespace MyFirstMobileApp.ViewViewModel.StackLayoutContents;

public class StackLayoutViewModel : ContentView
{

    //The data from TitleLayouts
    public string BtnStackLayout { get; set; } = TitleLayout.StackLayoutTitle;
    public string BtnVerticalStack { get; set; } = TitleLayout.VerticalStackTitle;
    public string BtnHorizontalStack { get; set; } = TitleLayout.HorizontalStackTitle;
    public string BtnAbsoluteLayout { get; set; } = TitleLayout.AbsoluteLayoutTitle;

    public StackLayoutViewModel()
    {

    }
}


