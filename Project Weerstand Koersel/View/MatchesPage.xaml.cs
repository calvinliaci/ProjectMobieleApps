using Project_Weerstand_Koersel.ViewModel;

namespace Project_Weerstand_Koersel.View;

public partial class MatchesPage : ContentPage
{
	public MatchesPage(MatchesPageViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}