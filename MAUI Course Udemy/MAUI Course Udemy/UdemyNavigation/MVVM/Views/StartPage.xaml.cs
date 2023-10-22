using MAUI_Course_Udemy.UdemyNavigation.MVVM.ViewModels;
using MAUI_Course_Udemy.UdemyNavigation.Utilities;

namespace MAUI_Course_Udemy.UdemyNavigation.MVVM.Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();

        BindingContext = new StartPageViewModel();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var currentViewModel = ((StartPageViewModel)BindingContext).Name;

		Navigation.PushAsync(new Page2
        {
            BindingContext = new Page2ViewModel
            {
                Name = currentViewModel
            }
        });

        //NavUtilities.DeletePage(Navigation, "StartPage");
    }
}