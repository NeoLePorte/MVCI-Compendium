using System.Collections.Generic;

namespace MVCI_Compendium.Models
{
    public class MoveModel
    {
        public string Type { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public List<InputModel> Inputs { get; set; }
    }
}
