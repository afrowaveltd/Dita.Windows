using Foundation;

namespace Dita.Maui.Platforms.MacCatalyst;
/// <summary>
/// AppDelegate class for the Mac Catalyst platform, responsible for application lifecycle management and initialization of the MAUI app.
/// </summary>
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
   /// <summary>
   /// Creates and returns the MAUI application instance. This method is called during the application startup process to initialize the app's main components and services.
   /// </summary>
   /// <returns></returns>
   protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
