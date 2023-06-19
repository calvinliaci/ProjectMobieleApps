using Project_Weerstand_Koersel.ViewModel;

namespace Project_Weerstand_Koersel.View;

public partial class AddPlayerPage : ContentPage
{
	public AddPlayerPage(AddPlayerPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}