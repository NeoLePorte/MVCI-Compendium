using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCI_Compendium.Models
{
    public class MoveModel
    {
        public int MoveModelId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }

        public string CharacterId { get; set; }
        public Character Character { get; set; }

        public ICollection<InputModel> Inputs { get; set; }

    }
}
