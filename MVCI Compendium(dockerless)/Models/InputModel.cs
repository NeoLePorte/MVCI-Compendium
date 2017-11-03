using System.Collections.Generic;

namespace MVCI_Compendium.Models
{
    public class InputModel
    {
        public int InputModelId { get; set; }
        public string Input { get; set; }

        public string GetIcon() => Input.Replace(" ", "-")
   .ToLower() + ".png";

        public ICollection<ComboInput> ComboInputs { get; set; }
        public ICollection<MoveInput> MoveInputs { get; set; }
    }

    
}
