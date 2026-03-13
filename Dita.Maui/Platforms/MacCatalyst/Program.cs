using UIKit;

namespace Dita.Maui.Platforms.MacCatalyst;

/// <summary>
/// Main entry point for the Mac Catalyst application, responsible for launching the app and initializing the AppDelegate, which manages the application lifecycle and sets up the MAUI app instance.
/// </summary>
public class Program
{
   // This is the main entry point of the application.
   static void Main(string[] args)
   {
      // if you want to use a different Application Delegate class from "AppDelegate"
      // you can specify it here.
      UIApplication.Main(args, null, typeof(AppDelegate));
   }
}