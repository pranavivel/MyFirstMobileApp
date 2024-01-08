namespace MyFirstMobileApp.ViewViewModel.InteractiveControls.Stepper;

public partial class StepperView : ContentPage
{
	public StepperView()
	{
		InitializeComponent();
        BindingContext = new StepperViewModel(); 
	}

	public void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
	{
		double value = e.NewValue;
		RotatingLable.Rotation = value;
		DisplayLabel.Text = string.Format("The Stepper value is {0}", value);
	}
}