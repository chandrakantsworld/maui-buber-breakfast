using CommunityToolkit.Maui;

namespace BuberBreakfast;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
				fonts.AddFont("Roboto-Regular.ttf", "RobotoRegular");
			}).UseMauiCommunityToolkit();

		return builder.Build();
	}
}
