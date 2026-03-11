namespace Dita.Shared.Models.Settings;

public class LibreTranslateBackend
{
   public string Server { get; set; } = "http://translate.afrowave.ltd";
   public string Key { get; set; } = "";
   public bool NeedsKey { get; set; } = false;
}
