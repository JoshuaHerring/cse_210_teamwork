// Josh is doing this

using System;
using System.Collections.Generic;

namespace Test
{
    public class director
    {
            word word = new word();
            jumper jumper = new jumper();
            terminalServices terminalServices = new terminalServices();
        public void startGame()
        {

            bool game = true;

            List<string> paraTrooper = jumper.originalImageGet();

            string chosenWord = word.chosenWord;
            List<string> letterList = word.letterListCreation(chosenWord);
            List<string> underscoredLetterList = word.underscoredListCreation();

            while (game == true)
            {
            terminalServices.printTrooper(paraTrooper);
            

            jumper.checkForFailure(paraTrooper);
            }


        }


    }
}