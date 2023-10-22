using MAUI_Course_Udemy.Models;

namespace MAUI_Course_Udemy.UdemyDataBinding;

public partial class FirstBindingDemo : ContentPage
{
	public FirstBindingDemo()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var person = new Person
		{
			Name = "John",
			Phone = "1234",
			Address = "1234 Main St"
		};

		BindingContext = person;

		//txtName.BindingContext = person;
		//txtName.SetBinding(Label.TextProperty, "Name");

		//Binding personBinding = new();

		//personBinding.Source = person;
		//personBinding.Path = "Name";

		//txtName.SetBinding(Label.TextProperty, personBinding);
	}
}