// Michael

using System;
using Raylib_cs;

namespace Greed_Game
{
    public class FallingObjects : Movement
    {
        public int down(int x)
        {
            x = moveDown(x);
            return x;
        }
        // make a method to generate a random number?

        // make a method to call a random number of fallingSprite from terminal services?
    }
}