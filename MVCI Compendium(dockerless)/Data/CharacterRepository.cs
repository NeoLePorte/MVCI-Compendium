using MVCI_Compendium.Models;

namespace MVCI_Compendium.Data
{
    public class CharacterRepository
    {
        private static Character[] _characters = new Character[]
{
    //Object initializer syntax
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
        Notes = ""
    },
    new Character()
    {
        Id = "Strider",
        Name = "Strider",
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
        Notes = ""
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
        Notes = ""
    },
    new Character()
    {
        Id = "Strider",
        Name = "Strider",
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
        Notes = ""
    },
    new Character()
    {
        Id = "Strider",
        Name = "Strider",
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
        Notes = ""
    },
    new Character()
    {
        Id = "Strider",
        Name = "Strider",
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
        Notes = ""
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
