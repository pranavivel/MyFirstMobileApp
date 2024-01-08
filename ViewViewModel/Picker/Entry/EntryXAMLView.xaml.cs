using MyFirstMobileApp._Resources.Models.Titles;

namespace MyFirstMobileApp.ViewViewModel.Picker.Entry;

public partial class EntryXAMLView : ContentPage
{
    public EntryXAMLView()
    {
        InitializeComponent();
        BindingContext = new EntryXAMLViewModel();
    }


    private void OnSubmitClicked(object sender, EventArgs e)
    {
        string entryText = EntryValue.Text;


        if (string.IsNullOrWhiteSpace(entryText))
        {
            //Entry is empty, show an alert
            Application.Current.MainPage.DisplayAlert(TitleEntry.EntryXAMLTitle, "Entry is empty. Please enter text.", "OK");
        }
        else
        {
            //Entry is not empty, notify the user of what they typed
            Application.Current.MainPage.DisplayAlert(TitleEntry.EntryXAMLTitle, "You entered: " + entryText, "OK");
        }


    }
}
