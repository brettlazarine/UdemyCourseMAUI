using MAUI_Course_Udemy.UdemyNavigation.Utilities;

namespace MAUI_Course_Udemy.UdemyNavigation.MVVM.Views;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        // Used for returning to the root page
        //Navigation.PopToRootAsync();
        NavUtilities.InsertPage(Navigation);
    }
}