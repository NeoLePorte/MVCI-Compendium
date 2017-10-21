using System.Collections.Generic;
namespace MVCI_Compendium.Models
{
    public class CharacterViewModel
    {
        public string CharacterId { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string Stamina { get; set; }
        public string Bio { get; set; }
        public List<Combo> Combos { get; set; }
        public List<MoveModel> MoveList { get; set; }
        public string Notes { get; set; }
        public string Faction { get; set; }

        public string Icon { get; set; }
    }
}
