using MVCI_Compendium.Models;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using System.Collections.Generic;

namespace MVCI_Compendium.Data
{
    public class CharacterRepository
    {
        private static List<Character> _characters = new List<Character>

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
        Stamina = "9,000",
        Bio = "<p>\"Striders\" is an intelligence organization with a long history. Among the Striders, Strider Hiryu is an elite intelligence operative and the youngest to attain the title of Special A-Class. Specialized in covert ops and assassination, he's a man who freely utilizes ninjutsu and high-tech weaponry. There seems to be rumors that his target, Grandmaster Meio, is working together with Ultron Sigma, and apparently Hiryu joined the resistance in order to investigate this.\"</p>",
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "Hard Punch"},
                   new InputModel() {Input = "Hard Punch"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },

        Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
        Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        Notes = "",
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
           new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
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
        Combos = new List<Combo>
        {
            new Combo() { Id = "1", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "2", Difficulty = "easy", Inputs = "", Type = "BnB" },
            new Combo() { Id = "3", Difficulty = "medium", Inputs = "", Type = "BnB" },
            new Combo() { Id = "4", Difficulty = "medium", Inputs = "", Type = "Flashy" },
            new Combo() { Id = "5", Difficulty = "hard", Inputs = "", Type = "BnB" },
        },
        MoveList = new List<MoveModel>
        {
            new MoveModel() { Id = "1", Type ="Special Moves", Name = "Ame-no-Murakumo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "2", Type="Special Moves", Name = "Excalibur", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "3", Type="Special Moves", Name = "Formation B", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "4", Type="Special Moves", Name = "Formation C", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "5", Type="Special Moves", Name = "Gram", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "6", Type="Special Moves", Name = "Vajra", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "7", Type="Special Moves", Name = "Wall Cling", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "8", Type="Hyper Combo", Name = "Brionac", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "9", Type="Hyper Combo", Name = "Legion", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "10", Type="Hyper Combo", Name = "Level 3 Hyper Combo", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "11", Type="Hyper Combo", Name = "Ouroboros", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "12", Type="Target Combos", Name = "Aerial Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "13", Type="Command Normals", Name = "Arch Cut", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "14", Type="Command Normals", Name = "Formation A1", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "15", Type="Command Normals", Name = "Formation A2", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "16", Type="Command Normals", Name = "Lateral Slice", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            },
            new MoveModel() { Id = "17", Type="Command Normals", Name = "Slide", Inputs = new List<InputModel>
                {
                   new InputModel() {Input = "up"},
                   new InputModel() {Input = "up"}
                }
            }
        },
         Videos = new List<CharVideos>
        {
            new CharVideos() { Id = "1", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "2", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "3", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "4", Title = "", Thumbnail = "", Details = "" },
            new CharVideos() { Id = "5", Title = "", Thumbnail = "", Details = "" },
        },
        Notes = "",
        Faction = "marvel"
    }
};
        public List<Character> GetCharacter()
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
