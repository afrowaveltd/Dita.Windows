namespace Dita.Maui;

/// <summary>
/// Represents the MAUI application entry point and window creation logic.
/// </summary>
public partial class App : Application
{
   /// <summary>
   /// Initializes a new instance of the <see cref="App"/> class.
   /// </summary>
   public App()
   {
      InitializeComponent();
   }

   /// <summary>
   /// Creates the main application window.
   /// </summary>
   /// <param name="activationState">The activation state used to create the window.</param>
   /// <returns>The created main window.</returns>
   protected override Window CreateWindow(IActivationState? activationState)
   {
      return new Window(new MainPage()) { Title = "Dita.Maui" };
   }
}
