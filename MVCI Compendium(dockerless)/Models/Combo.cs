using System.Collections.Generic;

namespace MVCI_Compendium.Models
{
    public class Combo
    {
        
        public int ComboId { get; set; }
        public string Difficulty { get; set; }
        public string Type { get; set; }
        public string CharacterId { get; set; }
        public Character Character { get; set; }


        public ICollection<InputModel> Inputs { get; set; }
    }
}