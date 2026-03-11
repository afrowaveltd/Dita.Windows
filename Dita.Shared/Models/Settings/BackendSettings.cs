namespace Dita.Shared.Models.Settings;

public class BackendSettings
{
   public string BackendId { get; set; } = Guid.NewGuid().ToString();
   public Branding Branding { get; set; } = new();
   public BackendLocalizationSettings LocalizationSettings { get; set; } = new();
   public List<LibreTranslateBackend> BackendTranslations { get; set; } = [];
   public SmtpSettings SmtpSettings { get; set; } = new();
   public bool UseSmtp = true;
}
