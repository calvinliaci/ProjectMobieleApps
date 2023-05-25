using Project_Weerstand_Koersel.ViewModel;

namespace Project_Weerstand_Koersel.View;

public partial class AuthenticationPage : ContentPage
{
	public AuthenticationPage(AuthenticationPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}