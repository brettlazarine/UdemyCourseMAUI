using MAUI_Course_Udemy.UdemyNavigation.Utilities;

namespace MAUI_Course_Udemy.UdemyNavigation.MVVM.Views;

public partial class CoolPage : ContentPage
{
	public CoolPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    // override the back button
    protected override bool OnBackButtonPressed()
    {
        return true;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PopModalAsync();
    }
}