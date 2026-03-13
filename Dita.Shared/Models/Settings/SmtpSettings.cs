using MailKit.Security;

namespace Dita.Shared.Models.Settings;

/// <summary>
/// Represents SMTP configuration used for sending emails.
/// </summary>
public class SmtpSettings
{
   /// <summary>
   /// Gets or sets a value indicating whether SMTP sending is enabled.
   /// </summary>
   public bool UseSmtp { get; set; } = false;

   /// <summary>
   /// Gets or sets the SMTP server host name or address.
   /// </summary>
   public string Server { get; set; } = string.Empty;

   /// <summary>
   /// Gets or sets the SMTP server port.
   /// </summary>
   public int Port { get; set; } = 25;

   /// <summary>
   /// Gets or sets the socket security mode used for SMTP connection.
   /// </summary>
   public SecureSocketOptions SocketOptions { get; set; } = SecureSocketOptions.Auto;

   /// <summary>
   /// Gets or sets a value indicating whether SMTP authentication is required.
   /// </summary>
   public bool UseAuthentication { get; set; } = false;

   /// <summary>
   /// Gets or sets the display name of the email sender.
   /// </summary>
   public string SenderName { get; set; } = string.Empty;

   /// <summary>
   /// Gets or sets the SMTP username used for authentication.
   /// </summary>
   public string Username { get; set; } = string.Empty;

   /// <summary>
   /// Gets or sets the SMTP password used for authentication.
   /// </summary>
   public string Password { get; set; } = string.Empty;
}
