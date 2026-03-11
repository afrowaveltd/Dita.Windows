namespace Dita.Shared.Models.Settings;

public class BackendLocalizationSettings
{
   public string DefaultLanguage { get; set; } = "en";
   public bool UseLibreTranslate { get; set; } = true;
   public bool StoreMissingTranslations { get; set; } = true;
   public bool AutoTranslate { get; set; } = true;
   public string LocaleFolder { get; set; } = "Locales";
   public int MaintenanceCycleInMinutes { get; set; } = 60;
   public List<LibreTranslateBackend> TranslationBackends { get; set; } = [];
}
