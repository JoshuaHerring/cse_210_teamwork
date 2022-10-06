using System;

namespace Test
{
    public class Director
    {
        ///<summary>
        ///Asks the player if they would like to start the game, then runs the game
        ///<para>This will run the entire game</para>
        ///</summary>
        public static void start()
        {
            bool onward = true;
            int score = 300;
            Console.WriteLine($"Your starting score is {score}\n");
            do
            {
            int card1 = Card.generateCard();
            string guess = Director.guesses();
            int card2 = Card.generateCard();
            score = Card.determineScore(guess, card1, card2, score);
            if(score <= 0)
            {
                onward = false;
                break;
            }
            else
                onward = proceed();
            }
            while(onward == true);
            if(onward == false)
            {
                Console.WriteLine($"That is the end of the game!");
            }

        }
        ///<summary>
        ///Asks the player what their guess is, then returns the string
        ///</summary>
        public static string guesses()
        {
            string guess;
            
            Console.Write("What is your guess? ('H,L') : ");
            guess = Console.ReadLine().ToLower();
            Console.WriteLine();


            while(guess != "h" && guess != "l")
            {
                Console.Write("You typed an invalid guess, please try again ('H,L') : ");
                guess = Console.ReadLine().ToLower();
            }

            return guess;
        }
        ///<summary>
        ///Asks the player if they would like to continue after they have gone through a full turn
        ///</summary>
        public static bool proceed()
        {
            Console.Write("Would you like to continue? (y/n) : ");
            string stringContinue = Console.ReadLine().ToLower();
            bool continueGame = false;
            while (stringContinue != "y" && stringContinue != "n")
            {
            Console.Write("Incorrect input, try again (y/n) : ");
            stringContinue = Console.ReadLine().ToLower();
            Console.WriteLine();
            }
            if(stringContinue == "y")
            {
                continueGame = true;
            }
            else
                continueGame = false;
            return continueGame;
        }

    }
}