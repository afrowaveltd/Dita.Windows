using MailKit.Security;

namespace Dita.Shared.Models.Settings;

public class SmtpSettings
{
   public string Server { get; set; } = string.Empty;
   public int Port { get; set; } = 25;
   public SecureSocketOptions SocketOptions { get; set; } = SecureSocketOptions.Auto;
   public bool UseAuthentication { get; set; } = false;
   public string SenderName { get; set; } = string.Empty;
   public string Username { get; set; } = string.Empty;
   public string Password { get; set; } = string.Empty;
}
