using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MVCI_Compendium.Models
{
    public class ComboView
    {
        public int? ComboId { get; set; }
        public string Difficulty { get; set; }
        public string Type { get; set; }

        public ICollection<InputModel> Inputs { get; set; }

        public List<SelectListItem> SelectInputs { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Up", Text = "Up" },
            new SelectListItem { Value = "Down", Text = "Down" },
            new SelectListItem { Value = "Left", Text = "Left"  },
            new SelectListItem { Value = "Right", Text = "Right" },
            new SelectListItem { Value = "Punch", Text = "Punch" },
            new SelectListItem { Value = "Light Punch", Text = "Light Punch"  },
            new SelectListItem { Value = "Hard Punch", Text = "Hard Punch" },
            new SelectListItem { Value = "Kick", Text = "Kick" },
            new SelectListItem { Value = "Light Kick", Text = "Light Kick"  },
            new SelectListItem { Value = "Hard Kick", Text = "Hard Kick"  },
            new SelectListItem { Value = "Tag", Text = "Tag"  },
            new SelectListItem { Value = "InfS", Text = "Infinity Stone"  },
        };
    }
}
