namespace MVCI_Compendium.Models
{
    public class InputModel
    {
        public string Input { get; set; }

        public string GetIcon() => Input.Replace(" ", "-")
   .ToLower() + ".svg";
    }
}
