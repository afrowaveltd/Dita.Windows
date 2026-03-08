using System;
using System.Collections.Generic;
using System.Text;

namespace Dita.Shared.Models.Settings;

public class Branding
{
   /// <summary>
   /// The company name to be used in the application. This can be displayed in various parts of the UI, such as the
   /// header, footer, or login page, to provide a consistent brand identity throughout the application.
   /// </summary>
   public string Name { get; set; } = string.Empty;

   /// <summary>
   /// Gets or sets the address associated with the entity.
   /// </summary>
   public string Address { get; set; } = string.Empty;
}
