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
        Order = 1,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Type="Special Moves", Name = "Ame-no-Murakumo", Inputs = "" },
            new MoveList() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = "" },
            new MoveList() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = "" },
            new MoveList() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = "" },
            new MoveList() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = "" },
            new MoveList() { Id = "5", Type="Special Moves", Name = "Vajra", Inputs = "" },
            new MoveList() { Id = "5", Type="Special Moves", Name = "Wall Cling", Inputs = "" },
            new MoveList() { Id = "4", Type="Hyper Combo", Name = "Brionac", Inputs = "" },
            new MoveList() { Id = "5", Type="Hyper Combo", Name = "Legion", Inputs = "" },
            new MoveList() { Id = "5", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = "" },
            new MoveList() { Id = "5", Type="Hyper Combo", Name = "Ouroboros", Inputs = "" },
            new MoveList() { Id = "5", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = "" },
            new MoveList() { Id = "5", Type="Command Normals", Name = "Arch Cut", Inputs = "" },
            new MoveList() { Id = "4", Type="Command Normals", Name = "Formation A1", Inputs = "" },
            new MoveList() { Id = "5", Type="Command Normals", Name = "Formation A2", Inputs = "" },
            new MoveList() { Id = "5", Type="Command Normals", Name = "Lateral Slice", Inputs = "" },
            new MoveList() { Id = "5", Type="Command Normals", Name = "Slide", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "stuff",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 2,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 3,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 4,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 5,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 6,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 7,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 8,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 9,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Faction = "capcom"
    },
    new Character()
    {
        Order = 10,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 11,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },
    new Character()
    {
        Order = 12,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"

    },
    new Character()
    {
        Order = 13,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"

    },
     new Character()
    {
        Order = 14,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"

    },
     new Character()
    {
        Order = 15,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "capcom"
    },

     //---------------------------------------------------------------------------------------------------------------------------------
                                                            //Marvel characters
     //---------------------------------------------------------------------------------------------------------------------------------
     new Character()
    {
        Order = 16,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 17,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 18,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 19,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 20,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 21,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 22,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 23,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 24,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 25,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 26,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    },
    new Character()
    {
        Order = 27,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"

    },
    new Character()
    {
        Order = 28,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"

    },
     new Character()
    {
        Order = 29,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"

    },
     new Character()
    {
        Order = 30,
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
        MoveList = new MoveList[]
        {
            new MoveList() { Id = "1", Name = "", Inputs = "" },
            new MoveList() { Id = "2", Name = "", Inputs = "" },
            new MoveList() { Id = "3", Name = "", Inputs = "" },
            new MoveList() { Id = "4", Name = "", Inputs = "" },
            new MoveList() { Id = "5", Name = "", Inputs = "" },
        },
        Videos = new Video[]
        {
            new Video() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new Video() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
