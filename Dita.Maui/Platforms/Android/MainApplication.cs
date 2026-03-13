using Android.App;
using Android.Runtime;

namespace Dita.Maui.Platforms.Android;

/// <summary>
/// Represents the Android application host for the MAUI app.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="MainApplication"/> class.
/// </remarks>
/// <param name="handle">The native application handle.</param>
/// <param name="ownership">The ownership mode for the JNI handle.</param>
[Application]
public class MainApplication(IntPtr handle, JniHandleOwnership ownership) : MauiApplication(handle, ownership)
{

   /// <summary>
   /// Creates the MAUI app instance.
   /// </summary>
   /// <returns>The configured <see cref="MauiApp"/> instance.</returns>
   protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
