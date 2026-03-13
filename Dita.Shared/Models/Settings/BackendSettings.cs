using Dita.Shared.Models.Settings.Enums;

namespace Dita.Shared.Models.Settings;

/// <summary>
/// Represents top-level backend application settings.
/// </summary>
public class BackendSettings
{
   /// <summary>
   /// Gets or sets the unique identifier of this backend instance.
   /// </summary>
   public string BackendId { get; set; } = Guid.NewGuid().ToString();

   /// <summary>
   /// Gets or sets branding settings.
   /// </summary>
   public Branding Branding { get; set; } = new();

   /// <summary>
   /// Gets or sets localization settings.
   /// </summary>
   public BackendLocalizationSettings LocalizationSettings { get; set; } = new();

   /// <summary>
   /// Gets or sets configured translation backend endpoints.
   /// </summary>
   public List<LibreTranslateBackend> BackendTranslations { get; set; } = [];

   /// <summary>
   /// Gets or sets SMTP settings.
   /// </summary>
   public SmtpSettings SmtpSettings { get; set; } = new();

   /// <summary>
   /// Gets or sets a value indicating whether SMTP should be used.
   /// </summary>
   public bool UseSmtp { get; set; } = true;

   /// <summary>
   /// Gets or sets the selected storage type.
   /// </summary>
   public StorageType StorageType { get; set; } = StorageType.AjisFiles;

   /// <summary>
   /// Gets or sets the backend database connection string.
   /// </summary>
   public string ConnectionString { get; set; } = string.Empty;

   /// <summary>
   /// Gets or sets the IP address of this backend server.
   /// </summary>
   public string ThisServerIp { get; set; } = string.Empty;
}
