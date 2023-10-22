namespace MAUI_Course_Udemy.UdemyConsumingRESTServices;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();

		BindingContext = new MainViewModel();
	}
}