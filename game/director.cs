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
        ///Asks the player what their guess is, then returns the int
        ///</summary>
        public static int guesses()
        {
            Card.generateCard();
            
            return 1;
        }
        ///<summary>
        ///Asks the player if they would like to continue after they have gone through a full turn
        ///</summary>
        public static bool proceed()
        {



            return true;
        }

    }
}