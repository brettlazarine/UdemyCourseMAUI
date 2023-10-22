using MAUI_Course_Udemy.UdemyMasteringCollectionView.MVVM.ViewModels;
using System.Diagnostics;

namespace MAUI_Course_Udemy.UdemyMasteringCollectionView.MVVM.Views;

public partial class ProductsView : ContentPage
{
	public ProductsView()
	{
		InitializeComponent();

		BindingContext = new ProductsViewModel();
	}

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
		Debug.WriteLine("--------------------");
		Debug.WriteLine($"HorizontalDelta: {e.HorizontalDelta}");
		Debug.WriteLine($"VerticalDelta: {e.VerticalDelta}");
		Debug.WriteLine($"HorizontalOffset: {e.HorizontalOffset}");
		Debug.WriteLine($"VerticalOffset: {e.VerticalOffset}");
		Debug.WriteLine($"FirstVisibleItemIndex: {e.FirstVisibleItemIndex}");
		Debug.WriteLine($"CenterItemIndex: {e.CenterItemIndex}");
		Debug.WriteLine($"LastVisibleItemIndex: {e.LastVisibleItemIndex}");
        Debug.WriteLine("--------------------");

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
		var vm = BindingContext as ProductsViewModel;

		vm.Products.Add(new Models.ProductsGroup("New Group",
			new List<Models.Product>
			{
				new Models.Product
				{
                    Id = 100,
					Name = "Bitcoin",
					Price = 999999
                }
			}));

		var product = vm.Products.SelectMany(p => p).FirstOrDefault(x => x.Id == 10);

		//collectionView.ScrollTo(product, animate: false, position: ScrollToPosition.Center);
    }
}