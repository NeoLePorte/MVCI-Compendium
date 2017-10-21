using System.Collections.Generic;
namespace MVCI_Compendium.Models
{
    public class Character
    {
        public string CharacterId { get; set; }
        public int Order {get; set;}
        public string Name { get; set; }
        public string Stamina { get; set; }
        public string Bio { get; set; }
        public string Notes  { get; set; }
        public string Faction { get; set; }

        public List<Combo> Combos { get; set; }
        public List<MoveModel> Moves { get; set; }

        public string GetIcon() => Name.Replace(" ", "-")
   .ToLower() + ".png";
    }
}