using MauiGrouping.Pages;
using MauiGrouping.ViewModels;
using Microsoft.Extensions.Logging;

namespace MauiGrouping;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<AnimalsPage>();
		builder.Services.AddTransient<AnimalsViewModel>();

		return builder.Build();
	}
}
