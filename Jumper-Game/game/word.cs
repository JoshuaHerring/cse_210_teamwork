using System;
using System.Collections.Generic;

namespace Test
{
    ///<summary>
    ///Generates the word, compares them, and allows you to to guess the word
    ///</summary>
    public class word
    {
        private jumper jumper = new jumper();
        static string[] possibleWords = {"ABRA", "AERODACTYL", "ALAKAZAM", "ARBOK", "ARCANINE", "ARTICUNO",
        "BEEDRILL", "BELLSPROUT", "BLASTOISE", "BULBASAUR", "BUTTERFREE", "CATERPIE", "CHANSEY", 
        "CHARIZARD", "CHARMANDER", "CHARMELEON", "CLEFABLE", "CLEFAIRY", "CLOYSTER", "CUBONE", 
        "DEWGONG", "DIGLETT", "DITTO", "DODRIO", "DODUO", "DRAGONAIR", "DRAGONITE", "DRATINI", 
        "DROWZEE", "DUGTRIO", "EEVEE", "EKANS", "ELECTABUZZ", "ELECTRODE", "EXEGGCUTE", "EXEGGUTOR", 
        "FARFETCHD", "FEAROW", "FLAREON", "GASTLY", "GENGAR", "GEODUDE", "GLOOM", 
        "GOLBAT", "GOLDEEN", "GOLDUCK", "GOLEM", "GRAVELER", "GRIMER", "GROWLITHE", 
        "GYARADOS", "HAUNTER", "HITMONCHAN", "HITMONLEE", "HORSEA", "HYPNO", "IVYSAUR", 
        "JIGGLYPUFF", "JOLTEON", "JYNX", "KABUTO", "KABUTOPS", "KADABRA", "KAKUNA", 
        "KANGASKHAN", "KINGLER", "KOFFING", "KRABBY", "LAPRAS", "LICKITUNG", "MACHAMP",
        "MACHOKE", "MACHOP", "MAGIKARP", "MAGMAR", "MAGNEMITE", "MAGNETON", "MANKEY", 
        "MAROWAK", "MEOWTH", "METAPOD", "MEW", "MEWTWO", "MOLTRES", "MR. MIME", "MUK",
        "NIDOKING", "NIDOQUEEN", "NIDORAN♀", "NIDORAN♂", "NIDORINA", "NIDORINO", "NINETALES", 
        "ODDISH", "OMANYTE", "OMASTAR", "ONIX", "PARAS", "PARASECT", "PERSIAN", "PIDGEOT", 
        "PIDGEOTTO", "PIDGEY", "PIKACHU", "PINSIR", "POLIWAG", "POLIWHIRL", "POLIWRATH", 
        "PONYTA", "PORYGON", "PRIMEAPE", "PSYDUCK", "RAICHU", "RAPIDASH", "RATICATE", 
        "RATTATA", "RHYDON", "RHYHORN", "SANDSHREW", "SANDSLASH", "SCYTHER", "SEADRA",
        "SEAKING", "SEEL", "SHELLDER", "SLOWBRO", "SLOWPOKE", "SNORLAX", "SPEAROW", 
        "SQUIRTLE", "STARMIE", "STARYU", "TANGELA", "TAUROS", "TENTACOOL", 
        "TENTACRUEL", "VAPOREON", "VENOMOTH", "VENONAT", "VENUSAUR", "VICTREEBEL", 
        "VILEPLUME", "VOLTORB", "VULPIX", "WARTORTLE", "WEEDLE", "WEEPINBELL", 
        "WEEZING", "WIGGLYTUFF", "ZAPDOS", "ZUBAT"};

        static Random rnd = new Random();
        static int numbers = rnd.Next(0, 151);

        public static string chosenWord = possibleWords[numbers];
        // public static string chosenWord = "hello";
        public List<string> letterListCreation(string chosenWord)
        {
            List<string> separatedWord = new List<string>();
            int lengthOfWord = chosenWord.Length - 1;
            for(int i = 0; i <= lengthOfWord; i++)
            {
                separatedWord.Add($"{chosenWord[i]}");
            }


            return separatedWord;
        }


        public List<string> underscoredListCreation()
        {
            List<string> underscoredList = new List<string>();
            List<string> separatedWord = letterListCreation(chosenWord);
            foreach(string i in separatedWord)
            {
                underscoredList.Add("_");
            }

            return underscoredList;
        }

        private List<string> compareGuess(string input, List<string> underscoredList, List<string> letterList)
        {
            int count = underscoredList.Count - 1;
            if(letterList.Contains(input))
            {
                for(int i = 0; i <= count; i++)
                {
                    if(letterList[i] == input)
                    {
                        underscoredList[i] = input;
                    }
                }
            }
            else
            {
                //Call Josh's edit image
            } 

            return underscoredList;
        }

        public bool goodEnding(List<string> underscoredList, List<string> letterList)
        {
            if(underscoredList == letterList)
            {
                return true;
            }
            else
                return false;
        }

    }
}