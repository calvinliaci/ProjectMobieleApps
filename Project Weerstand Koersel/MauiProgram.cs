using Microsoft.Extensions.Logging;
using Project_Weerstand_Koersel.Service;
using Project_Weerstand_Koersel.View;
using Project_Weerstand_Koersel.ViewModel;

namespace Project_Weerstand_Koersel;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<ISpelerService, SpelerService>();
        builder.Services.AddTransient<IMatchService, MatchService>();

        builder.Services.AddTransient<MainPageViewModel>();
		builder.Services.AddTransient<PlayersPageViewModel>();
		builder.Services.AddTransient<PlayerDetailPageViewModel>();
        builder.Services.AddTransient<MatchesPageViewModel>();
        builder.Services.AddTransient<AuthenticationPageViewModel>();
        builder.Services.AddTransient<ChangeStatsPageViewModel>();

        builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<PlayersPage>();
        builder.Services.AddTransient<PlayerDetailPage>();
        builder.Services.AddTransient<MatchesPage>();
        builder.Services.AddTransient<AuthenticationPage>();
        builder.Services.AddTransient<ChangeStatsPage>();

        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);


        return builder.Build();
	}
}
