using Project_Weerstand_Koersel.ViewModel;

namespace Project_Weerstand_Koersel.View;

public partial class PlayersPage : ContentPage
{
	public PlayersPage(PlayersPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}