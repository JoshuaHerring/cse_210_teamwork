using System;

namespace Test
{
    public class Director
    {
        ///<summary>
        ///Asks the player if they would like to start the game, then runs the game
        ///<para>This will run the entire game</para>
        ///</summary>
        public static string start()
        {
            return "";
        }
        ///<summary>
        ///Asks the player what their guess is, then returns the string
        ///</summary>
        public static string guesses()
        {
            string guess;
            Console.WriteLine("What is your guess? ('H,L') : ");
            guess = Console.ReadLine().ToLower();
            while(guess != "h" || guess != "l")
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
            if(stringContinue == "t")
            {
                
            }

            return true;
        }

    }
}