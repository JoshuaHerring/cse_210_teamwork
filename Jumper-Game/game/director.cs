// Josh is doing this

using System;
using System.Collections.Generic;

namespace Test
{
    public class director
    {
            private word word = new word();
            private jumper jumper = new jumper();
            private terminalServices terminalServices = new terminalServices();
        public void startGame()
        {

            bool gameOver = false;

            List<string> paraTrooper = jumper.originalImageGet();

            string chosenWord = word.chosenWord;
            List<string> letterList = word.letterListCreation(chosenWord);
            List<string> underscoredList = word.underscoredListCreation();

            while (!gameOver)
            {
            terminalServices.printTrooper(paraTrooper);
            terminalServices.printList(underscoredList);
            string gueess = terminalServices.Input("What is your guess? ");


            if(word.checkForGuess(gueess, underscoredList, letterList))
            {
                word.underscoredListEditor(gueess, underscoredList, letterList);
            }
            else
            {
                underscoredList = jumper.editImage(underscoredList);
            }

            gameOver = word.goodEnding(underscoredList, letterList);
            if(gameOver)
                break;
            // gameOver = jumper.checkForFailure(paraTrooper);
            // if(gameOver)
            //     break;
            }


        }


    }
}