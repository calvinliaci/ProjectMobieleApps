using Project_Weerstand_Koersel.View;

namespace Project_Weerstand_Koersel;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();


        Routing.RegisterRoute(nameof(PlayerDetailPage), typeof(PlayerDetailPage));
        Routing.RegisterRoute(nameof(AddPlayerPage), typeof(AddPlayerPage));
        Routing.RegisterRoute(nameof(PlayersPage), typeof(PlayersPage));
    }
}
