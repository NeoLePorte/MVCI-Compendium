using MVCI_Compendium.Models;

namespace MVCI_Compendium.Data
{
    public class CharacterRepository
    {
        private static Character[] _characters = new Character[]
{
    //Object initializer syntax
     //---------------------------------------------------------------------------------------------------------------------------------
                                                            //Capcom Characters
     //---------------------------------------------------------------------------------------------------------------------------------
    new Character()
    {
        Id = "Strider",
        Name = "Strider",
        Stamina = "700",
        Bio = "<p>\"Striders\" is an intelligence organization with a long history. Among the Striders, Strider Hiryu is an elite intelligence operative and the youngest to attain the title of Special A-Class. Specialized in covert ops and assassination, he's a man who freely utilizes ninjutsu and high-tech weaponry. There seems to be rumors that his target, Grandmaster Meio, is working together with Ultron Sigma, and apparently Hiryu joined the resistance in order to investigate this.\"</p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Arthur",
        Name = "Arthur",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Frank West",
        Name = "Frank West",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Chris Redfield",
        Name = "Chris Redfield",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Mega man X",
        Name = "Mega man X",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Zero",
        Name = "Zero",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Nemesis",
        Name = "Nemesis",
        Stamina = "700",
        Bio = "<p>\"Striders\" is an intelligence organization with a long history. Among the Striders, Strider Hiryu is an elite intelligence operative and the youngest to attain the title of Special A-Class. Specialized in covert ops and assassination, he's a man who freely utilizes ninjutsu and high-tech weaponry. There seems to be rumors that his target, Grandmaster Meio, is working together with Ultron Sigma, and apparently Hiryu joined the resistance in order to investigate this.\"</p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Dante",
        Name = "Dante",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Ryu",
        Name = "Ryu",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Spencer",
        Name = "Spencer",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Chun-Li",
        Name = "Chun-Li",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Id = "Morrigan",
        Name = "Morrigan",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"

    },
    new Character()
    {
        Id = "Firebrand",
        Name = "Firebrand",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"

    },
     new Character()
    {
        Id = "Jedah",
        Name = "Jedah",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"

    },
     new Character()
    {
        Id = "Haggar",
        Name = "Haggar",
        Stamina = "700",
        Bio = "<p><strong>Mayor OF EARTH!</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "capcom"
    },

     //---------------------------------------------------------------------------------------------------------------------------------
                                                            //Marvel characters
     //---------------------------------------------------------------------------------------------------------------------------------
     new Character()
    {
        Id = "Rocket Raccoon",
        Name = "Rocket Raccoon",
        Stamina = "700",
        Bio = "<p>\"Striders\" is an intelligence organization with a long history. Among the Striders, Strider Hiryu is an elite intelligence operative and the youngest to attain the title of Special A-Class. Specialized in covert ops and assassination, he's a man who freely utilizes ninjutsu and high-tech weaponry. There seems to be rumors that his target, Grandmaster Meio, is working together with Ultron Sigma, and apparently Hiryu joined the resistance in order to investigate this.\"</p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Dr Strange",
        Name = "Dr Strange",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Hawkeye",
        Name = "Hawkeye",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Ultron",
        Name = "Ultron",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Gamora",
        Name = "Gamora",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Spider Man",
        Name = "Spider Man",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Iron Man",
        Name = "Iron Man",
        Stamina = "700",
        Bio = "<p>\"Striders\" is an intelligence organization with a long history. Among the Striders, Strider Hiryu is an elite intelligence operative and the youngest to attain the title of Special A-Class. Specialized in covert ops and assassination, he's a man who freely utilizes ninjutsu and high-tech weaponry. There seems to be rumors that his target, Grandmaster Meio, is working together with Ultron Sigma, and apparently Hiryu joined the resistance in order to investigate this.\"</p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Thanos",
        Name = "Thanos",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Nova",
        Name = "Nova",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Hulk",
        Name = "Hulk",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Captain Marvel",
        Name = "Captain Marvel",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Id = "Thor",
        Name = "Thor",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"

    },
    new Character()
    {
        Id = "Captain America",
        Name = "Captain America",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"

    },
     new Character()
    {
        Id = "Dormammu",
        Name = "Dormammu",
        Stamina = "700",
        Bio = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"

    },
     new Character()
    {
        Id = "Ghost Rider",
        Name = "Ghost Rider",
        Stamina = "700",
        Bio = "<p><strong>Mayor OF EARTH!</strong></p>",
        Combos = new Combo[]
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "" },
        },
        Notes = "",
        Faction = "marvel"
    }
};
        public Character[] GetCharacter()
        {
            return _characters;
        }


        public Character GetCharacter(string id)
        {
            Character characterToReturn = null;

            foreach (var character in _characters)
            {
                if (character.Id == id)
                {
                    characterToReturn = character;

                    break;
                }
            }

            return characterToReturn;
        }
    }
}
