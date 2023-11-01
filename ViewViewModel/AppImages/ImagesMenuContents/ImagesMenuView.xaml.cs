namespace MyFirstMobileApp.ViewViewModel.AppImages.ImagesMenuContents;

public partial class ImagesMenuView : ContentPage
{
	public ImagesMenuView()
	{
        InitializeComponent();
        BindingContext = new ImagesMenuViewModel();
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}