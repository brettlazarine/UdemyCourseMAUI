using MAUI_Course_Udemy.Pages;
using MAUI_Course_Udemy.UdemyConsumingRESTServices;
using MAUI_Course_Udemy.UdemyControls;
using MAUI_Course_Udemy.UdemyDataBinding;
using MAUI_Course_Udemy.UdemyExternalResources;
using MAUI_Course_Udemy.UdemyMasteringCollectionView.MVVM.Views;
using MAUI_Course_Udemy.UdemyNavigation.MVVM.Views;
using MAUI_Course_Udemy.UdemyStyles;

namespace MAUI_Course_Udemy;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		var navPage = new NavigationPage(new MainPage());
		navPage.BarBackgroundColor = Colors.Chocolate;
		navPage.BarTextColor = Colors.White;

		MainPage = new MainView();
	}
}
