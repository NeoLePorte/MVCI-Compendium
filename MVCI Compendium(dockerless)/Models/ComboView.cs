using System.Collections.Generic;

namespace MVCI_Compendium.Models
{
    public class ComboView
    {
        public int? ComboId { get; set; }
        public string Difficulty { get; set; }
        public string Type { get; set; }

        public ICollection<InputModel> Inputs { get; set; }
    }
}
