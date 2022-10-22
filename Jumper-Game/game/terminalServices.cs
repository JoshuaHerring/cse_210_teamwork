using System;

namespace Test
{
    public class terminalServices
    {
        public string Input(string text)
        {

            Console.Write(text);
            string input = Console.ReadLine().ToUpper();
            while(input != "A" && input != "B" && input != "C" && input != "D" && input != "E" && input != "F" && input != "G" && input != "H" && input != "I" && input != "J" && input != "K" && input != "L" && input != "M" && input != "N" && input != "O" && input != "P" && input != "Q" && input != "R" && input != "S" && input != "T" && input != "U" && input != "V" && input != "W" && input != "X" && input != "Y" && input != "Z")
            {
                Console.Write("You can only input one letter at a time \nAnd it has to be a letter, please try again : ");
                input = Console.ReadLine().ToUpper();
            }
            return input;
        }
    }
}