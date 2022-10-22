// Josh is doing this

using System;
using System.Collections.Generic;

namespace Test
{
    public class director
    {
            word word = new word();
            jumper jumper = new jumper();
        public void startGame()
        {
            List<string> paratrooper = jumper.originalImageGet();
            int lengthOfImage = paratrooper.Count;
            for (int y = 0; y < lengthOfImage; y++)
                {
                Console.WriteLine(paratrooper[y]);
                }
            Console.WriteLine();

            string chosenWord = word.chosenWord;
            List<string> letterList = word.letterListCreation(chosenWord);
        }


    }
}