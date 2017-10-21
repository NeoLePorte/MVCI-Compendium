using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCI_Compendium.Models;

namespace MVCI_Compendium.Data
{
    public class DbInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();

            // Look for any characters.
            if (context.Characters.Any())
            {
                return;   // DB has been seeded
            }

            var characters = new List<Character>
            {

    new Character()
    {
        Order = 1,
        CharacterId = "Strider",
        Name = "Strider",
        Stamina = "9,000",
        Bio = "<p>\"Striders\" is an intelligence organization with a long history. Among the Striders, Strider Hiryu is an elite intelligence operative and the youngest to attain the title of Special A-Class. Specialized in covert ops and assassination, he's a man who freely utilizes ninjutsu and high-tech weaponry. There seems to be rumors that his target, Grandmaster Meio, is working together with Ultron Sigma, and apparently Hiryu joined the resistance in order to investigate this.\"</p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "Hard Punch"},
                   new InputModel() {Input = "Hard Punch"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
        Notes = "stuff",
        Faction = "capcom"
    },


    new Character()
    {
        Order = 2,
        CharacterId = "Arthur",
        Name = "Arthur",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },

        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 3,
        CharacterId = "Frank West",
        Name = "Frank West",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 4,
        CharacterId = "Chris Redfield",
        Name = "Chris Redfield",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },

        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 5,
        CharacterId = "Mega man X",
        Name = "Mega man X",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 6,
        CharacterId = "Zero",
        Name = "Zero",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 7,
        CharacterId = "Nemesis",
        Name = "Nemesis",
        Stamina = "700",
        Bio = "<p>\"Striders\" is an intelligence organization with a long history. Among the Striders, Strider Hiryu is an elite intelligence operative and the youngest to attain the title of Special A-Class. Specialized in covert ops and assassination, he's a man who freely utilizes ninjutsu and high-tech weaponry. There seems to be rumors that his target, Grandmaster Meio, is working together with Ultron Sigma, and apparently Hiryu joined the resistance in order to investigate this.\"</p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 8,
        CharacterId = "Dante",
        Name = "Dante",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 9,
        CharacterId = "Ryu",
        Name = "Ryu",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Notes = "",
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Faction = "capcom"
    },
    new Character()
    {
        Order = 10,
        CharacterId = "Spencer",
        Name = "Spencer",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 11,
        CharacterId = "Chun-Li",
        Name = "Chun-Li",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 12,
        CharacterId = "Morrigan",
        Name = "Morrigan",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"

    },
    new Character()
    {
        Order = 13,
        CharacterId = "Firebrand",
        Name = "Firebrand",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"

    },
     new Character()
    {
        Order = 14,
        CharacterId = "Jedah",
        Name = "Jedah",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"

    },
     new Character()
    {
        Order = 15,
        CharacterId = "Haggar",
        Name = "Haggar",
        Stamina = "700",
        Bio = "<p><strong>Mayor OF EARTH!</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "capcom"
    },
     new Character()
    {
        Order = 16,
        CharacterId = "Rocket Raccoon",
        Name = "Rocket Raccoon",
        Stamina = "700",
        Bio = "<p>\"Striders\" is an intelligence organization with a long history. Among the Striders, Strider Hiryu is an elite intelligence operative and the youngest to attain the title of Special A-Class. Specialized in covert ops and assassination, he's a man who freely utilizes ninjutsu and high-tech weaponry. There seems to be rumors that his target, Grandmaster Meio, is working together with Ultron Sigma, and apparently Hiryu joined the resistance in order to investigate this.\"</p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 17,
        CharacterId = "Dr Strange",
        Name = "Dr Strange",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 18,
        CharacterId = "Hawkeye",
        Name = "Hawkeye",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 19,
        CharacterId = "Ultron",
        Name = "Ultron",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 20,
        CharacterId = "Gamora",
        Name = "Gamora",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 21,
        CharacterId = "Spider Man",
        Name = "Spider Man",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 22,
        CharacterId = "Iron Man",
        Name = "Iron Man",
        Stamina = "700",
        Bio = "<p>\"Striders\" is an intelligence organization with a long history. Among the Striders, Strider Hiryu is an elite intelligence operative and the youngest to attain the title of Special A-Class. Specialized in covert ops and assassination, he's a man who freely utilizes ninjutsu and high-tech weaponry. There seems to be rumors that his target, Grandmaster Meio, is working together with Ultron Sigma, and apparently Hiryu joined the resistance in order to investigate this.\"</p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 23,
        CharacterId = "Thanos",
        Name = "Thanos",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 24,
        CharacterId = "Nova",
        Name = "Nova",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 25,
        CharacterId = "Hulk",
        Name = "Hulk",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 26,
        CharacterId = "Captain Marvel",
        Name = "Captain Marvel",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 27,
        CharacterId = "Thor",
        Name = "Thor",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"

    },
    new Character()
    {
        Order = 28,
        CharacterId = "Captain America",
        Name = "Captain America",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"

    },
     new Character()
    {
        Order = 29,
        CharacterId = "Dormammu",
        Name = "Dormammu",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"

    },
     new Character()
    {
        Order = 30,
        CharacterId = "Ghost Rider",
        Name = "Ghost Rider",
        Stamina = "700",
        Bio = "<p><strong>Mayor OF EARTH!</strong></p>",
        Combos = new List<Combo>
        {
            new Combo() {  Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
                ,Type = "BnB" },
            new Combo() { Difficulty = "easy", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }

                ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
            new Combo() { Difficulty = "medium", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "Flashy" },
            new Combo() { Difficulty = "hard", Inputs =
                new List<InputModel>
            {
                new InputModel() {Input = "Light Punch" },
                new InputModel() {Input = "Heavy Punch" },
                new InputModel() {Input = "Ame-no-Murakumo" },
            }
            ,Type = "BnB" },
        },
        Moves = new List<MoveModel>
        {
            new MoveModel() {Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel()  {Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() {Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },


        Notes = "",
        Faction = "marvel"
    }
};



            foreach (Character c in characters)
                {
                    context.Characters.Add(c);
                }
                context.SaveChanges();

                }
 
    }
}