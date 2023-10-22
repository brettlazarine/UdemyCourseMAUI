using MAUI_Course_Udemy.UdemyMasteringCollectionView.MVVM.ViewModels;

namespace MAUI_Course_Udemy.UdemyMasteringCollectionView.MVVM.Views;

public partial class LayoutsPage : ContentPage
{
	public LayoutsPage()
	{
		InitializeComponent();

		BindingContext = new DataViewModel();
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		var element = e.CurrentSelection;
    }
}