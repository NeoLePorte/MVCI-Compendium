namespace MVCI_Compendium.Models
{
    public class Character
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Stamina { get; set; }
        public string Bio { get; set; }
        public Combo[] Combos { get; set; }
        public MoveList[] MoveList { get; set; }
        public Video[] Videos { get; set; }
        public string Notes  { get; set; }

        public string Icon => Name.Replace(" ", "-")
                     .ToLower() + ".png";
    }
}