using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MVCI_Compendium.Models
{
    public class Input
    {
        [Key]
        public string InputValue { get; set; }

        public string GetIcon() => InputValue.Replace(" ", "-")
   .ToLower() + ".png";
    }
}
