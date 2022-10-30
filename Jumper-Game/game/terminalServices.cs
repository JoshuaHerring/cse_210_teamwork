using System;
using System.Collections.Generic;

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

              ///<summary> Prints any length of paratrooper to the console </summary>
        public void printTrooper(List<string> paratrooper)
        {
             int lengthOfImage = paratrooper.Count;
            for (int y = 0; y < lengthOfImage; y++)
                {
                Console.WriteLine(paratrooper[y]);
                }
            Console.WriteLine();
        }

        ///<summary> Prints any length list to the console on the same line </summary>
        public void printList(List<string> list)
        {
             int lengthOfImage = list.Count;
            for (int y = 0; y < lengthOfImage; y++)
                {
                Console.Write($"{list[y]} ");
                }
            Console.WriteLine();
        }

                ///<summary> Prints the failed result along with the correct word</summary>
        public void failed(List<string> letterList, List<string> underscoredList, List<string> paraTrooper)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            printTrooper(paraTrooper);
            Console.WriteLine("You have died");
            printList(underscoredList);

            Console.WriteLine();
            Console.WriteLine("The correct word was:");
            printList(letterList);
        }

        public void victory(List<string> letterList, List<string> paraTrooper)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            printTrooper(paraTrooper);
            printList(letterList);
            Console.WriteLine("Congragulations You Won");
        }

    }
}