using Foundation;

namespace Dita.Maui.Platforms.iOS;

/// <summary>
/// AppDelegate class for the iOS platform, responsible for application lifecycle management and initialization of the MAUI app.
/// </summary>
[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
   /// <summary>
   /// Creates the MAUI application instance by calling the CreateMauiApp method from the MauiProgram class, which sets up the app's services and configurations.
   /// </summary>
   /// <returns>MauiApp</returns>
   protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
