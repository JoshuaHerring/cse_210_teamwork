// Michael

using System;
using Raylib_cs;

namespace Greed_Game
{
    public class FallingObjects : Movement
    {
        public int down(int y)
        {
            y = moveDown(y);
            return y;
        }

        public int randomNumber()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 1001);

            return x;
        }

        // make a method to generate a random number?
    }
}