using UdemySQLiteMAUI.MVVM.ViewModels;

namespace UdemySQLiteMAUI.MVVM.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainPageViewModel();
	}
}