using UdemyMAUIMVVM.MVVM.ViewModels;

namespace UdemyMAUIMVVM.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();

		BindingContext = new PeopleViewModel();
	}
}