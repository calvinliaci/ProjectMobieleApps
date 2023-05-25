using Project_Weerstand_Koersel.ViewModel;

namespace Project_Weerstand_Koersel.View;

public partial class ChangeStatsPage : ContentPage
{
	public ChangeStatsPage(ChangeStatsPageViewModel viewModel)
	{
		InitializeComponent();

		BindingContext = viewModel;
	}
}