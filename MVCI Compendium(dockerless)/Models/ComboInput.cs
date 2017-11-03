namespace MVCI_Compendium.Models
{
    public class ComboInput
    {
        public int ComboId { get; set; }
        public string InputValue { get; set; }
        public virtual InputModel Input { get; set; }

        public string GetIcon() => InputValue.Replace(" ", "-")
   .ToLower() + ".png";
    }
}
