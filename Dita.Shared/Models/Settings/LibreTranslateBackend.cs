namespace Dita.Shared.Models.Settings;

/// <summary>
/// Represents the configuration settings for a LibreTranslate backend server.
/// </summary>
public class LibreTranslateBackend
{
   /// <summary>
   /// Gets or sets the LibreTranslate server URL.
   /// </summary>
   public string Server { get; set; } = "http://translate.afrowave.ltd";
   
   /// <summary>
   /// Gets or sets the API key for authenticating with the LibreTranslate server.
   /// </summary>
   public string Key { get; set; } = "";
   
   /// <summary>
   /// Gets or sets a value indicating whether the LibreTranslate server requires an API key for authentication.
   /// </summary>
   public bool NeedsKey { get; set; } = false;
}
