using UdemyMAUIMVVM.MVVM.Views;

namespace UdemyMAUIMVVM;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CommandsView();
	}
}
