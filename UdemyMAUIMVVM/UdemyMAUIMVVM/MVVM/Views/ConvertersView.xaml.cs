using UdemyMAUIMVVM.MVVM.ViewModels;

namespace UdemyMAUIMVVM.MVVM.Views;

public partial class ConvertersView : ContentPage
{
	public ConvertersView()
	{
		InitializeComponent();

		BindingContext = new ConvertersViewModel();
	}
}