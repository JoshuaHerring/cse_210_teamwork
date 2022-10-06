using System;

namespace Test
{
    public class Card
    {
        ///<summary>
        ///<para>Choose a card to display to the player</para>
        ///Returns an int between 1 and 13
        ///</summary>
        public static int generateCard()
            {
                Random rnd = new Random();
                int number = rnd.Next(1, 14);
                Console.WriteLine($"The card is {number}\n");

                return number;
            }

            ///<summary>
            ///Calculates the score based off of the card and the players guess
            /// return score
            ///</summary>
            public static int determineScore(string guess, int card1, int card2, int score)
            {

                if (card1 < card2 && guess == "h")
                {
                    score += 100;
                    Console.WriteLine($"You guessed right! Your new score is {score}\n");
                }
                else if (card1 > card2 && guess == "l")
                {
                    score += 100;
                    Console.WriteLine($"You guessed right! Your new score is {score}\n");
                }
                else
                {
                    score -= 75;
                    Console.WriteLine($"You guessed wrong! Your new score is {score}\n");
                }
                return score;
            }
    }
}