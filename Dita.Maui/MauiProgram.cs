using Microsoft.Extensions.Logging;

namespace Dita.Maui;

/// <summary>
/// Provides startup configuration for the MAUI application.
/// </summary>
public static class MauiProgram
{
   /// <summary>
   /// Creates and configures the MAUI application instance.
   /// </summary>
   /// <returns>A configured <see cref="MauiApp"/> instance.</returns>
   public static MauiApp CreateMauiApp()
   {
      var builder = MauiApp.CreateBuilder();
      builder
         .UseMauiApp<App>()
         .ConfigureFonts(fonts =>
         {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
         });

      builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

      return builder.Build();
   }
}
