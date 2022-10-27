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

            bool gameOver = false;

            List<string> paraTrooper = jumper.originalImageGet();

            string chosenWord = word.chosenWord;
            List<string> letterList = word.letterListCreation(chosenWord);
            List<string> underscoredLetterList = word.underscoredListCreation();

            while (gameOver == false)
            {
            terminalServices.printTrooper(paraTrooper);
            terminalServices.printTrooper(underscoredLetterList);
            string gueess = terminalServices.Input("What is your guess? ");

            word.compareGuess(gueess, underscoredLetterList, letterList);
            gameOver = word.goodEnding(underscoredLetterList, letterList);
            gameOver = jumper.checkForFailure(paraTrooper);
            }


        }


    }
}