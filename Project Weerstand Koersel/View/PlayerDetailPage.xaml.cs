using Project_Weerstand_Koersel.ViewModel;

namespace Project_Weerstand_Koersel.View;

public partial class PlayerDetailPage : ContentPage
{
	public PlayerDetailPage(PlayerDetailPageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}