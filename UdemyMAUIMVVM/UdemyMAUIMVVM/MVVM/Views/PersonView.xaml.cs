using UdemyMAUIMVVM.MVVM.Models;
using UdemyMAUIMVVM.MVVM.ViewModels;

namespace UdemyMAUIMVVM.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();
		
		

		BindingContext = new PersonViewModel();
	}
}