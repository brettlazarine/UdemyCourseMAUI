using MAUI_Course_Udemy.UdemyMasteringCollectionView.MVVM.ViewModels;

namespace MAUI_Course_Udemy.UdemyMasteringCollectionView.MVVM.Views;

public partial class DataView : ContentPage
{
	public DataView()
	{
		InitializeComponent();

		BindingContext = new DataViewModel();
	}
}