using UdemyMAUIMVVM.MVVM.ViewModels;

namespace UdemyMAUIMVVM.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();

		BindingContext = new CommandsViewModel();
	}
}