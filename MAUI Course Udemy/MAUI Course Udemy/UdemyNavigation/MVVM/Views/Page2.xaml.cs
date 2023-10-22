using MAUI_Course_Udemy.UdemyNavigation.Utilities;

namespace MAUI_Course_Udemy.UdemyNavigation.MVVM.Views;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}
    public Page2(string name)
    {
        InitializeComponent();

        //txtName.Text = name;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FinalPage());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}