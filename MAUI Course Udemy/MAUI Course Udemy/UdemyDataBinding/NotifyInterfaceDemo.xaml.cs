using MAUI_Course_Udemy.Models;

namespace MAUI_Course_Udemy.UdemyDataBinding;

public partial class NotifyInterfaceDemo : ContentPage
{
	public NotifyInterfaceDemo()
	{
		InitializeComponent();

        person = new Person
        {
            Name = "John",
            Phone = "1234",
            Address = "1234 Main St"
        };
        BindingContext = person;
    }

    Person person = new();

    private void OnCounterClicked(object sender, EventArgs e)
    {
        person.Name = "Jane";
        person.Phone = "5678";
        person.Address = "5678 Main St";

        //txtName.BindingContext = person;
        //txtName.SetBinding(Label.TextProperty, "Name");

        //Binding personBinding = new();

        //personBinding.Source = person;
        //personBinding.Path = "Name";

        //txtName.SetBinding(Label.TextProperty, personBinding);
    }
}