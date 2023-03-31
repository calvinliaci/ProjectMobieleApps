using Microsoft.Extensions.Logging;
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

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<MainPageViewModel>();

        return builder.Build();
	}
}
