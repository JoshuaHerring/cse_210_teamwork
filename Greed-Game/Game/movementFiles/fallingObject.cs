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
    }
}