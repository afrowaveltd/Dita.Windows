namespace Dita.Shared.Models.Settings;

/// <summary>
/// Represents localization and translation behavior settings for the backend.
/// </summary>
public class BackendLocalizationSettings
{
   /// <summary>
   /// Gets or sets the default language code.
   /// </summary>
   public string DefaultLanguage { get; set; } = "en";

   /// <summary>
   /// Gets or sets a value indicating whether LibreTranslate integration is enabled.
   /// </summary>
   public bool UseLibreTranslate { get; set; } = true;

   /// <summary>
   /// Gets or sets a value indicating whether missing translations should be stored.
   /// </summary>
   public bool StoreMissingTranslations { get; set; } = true;

   /// <summary>
   /// Gets or sets a value indicating whether automatic translation is enabled.
   /// </summary>
   public bool AutoTranslate { get; set; } = true;

   /// <summary>
   /// Gets or sets the folder path where localization resources are stored.
   /// </summary>
   public string LocaleFolder { get; set; } = "Locales";

   /// <summary>
   /// Gets or sets the maintenance cycle interval in minutes.
   /// </summary>
   public int MaintenanceCycleInMinutes { get; set; } = 60;

   /// <summary>
   /// Gets or sets the configured translation backends.
   /// </summary>
   public List<LibreTranslateBackend> TranslationBackends { get; set; } = [];
}
