// Michael

using System;
using Raylib_cs;

namespace Greed_Game
{
    public class FallingObjects : Movement
    {
        int down(int x)
        {
            moveDown(x);
            return x;
        }
    }
}