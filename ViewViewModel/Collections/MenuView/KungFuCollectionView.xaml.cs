using System.Security.Cryptography.X509Certificates;

namespace MyFirstMobileApp.ViewViewModel.Collections.MenuView;

public partial class KungFuCollectionView : ContentPage
{
	public KungFuCollectionView()
	{
        InitializeComponent();
        BindingContext = new KungFuCollectionView();

    }
}