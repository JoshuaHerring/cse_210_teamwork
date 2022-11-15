// Josh Is doing this
using System;

namespace Greed_Game
{
    public class Score
    {
        ///<summary> Increments score </summary>
        public int pointGained(int score)
        {
            score++;
            return score;
        }

        /// <summary> decrements score </summary>
        public int pointLost(int score)
        {
            score--;
            return score;
        }

        /// <summary> Input score to determine if game is over
        ///<para> returns bool true if game is over </para>
        /// </summary>
        public bool gameOver(int score)
        {
            bool gameOver = false;
            if (score <=-1)
            {
                gameOver = true;
            }
            return gameOver;
        }

    }
}