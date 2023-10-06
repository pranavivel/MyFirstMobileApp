namespace MyFirstMobileApp.ViewViewModel.Layouts.StackLayoutContents;

public partial class StackLayoutView : ContentPage
{
    //NOT NEEDED for this project
	public StackLayoutView()
	{
        
        //Add binding and create StackLayoutView page
        InitializeComponent(); 
        BindingContext = new StackLayoutViewModel();
	}
}