// Michael

using System;
using Raylib_cs;

namespace Greed_Game
{
    public class Collision
    {
        ///<summary>
        ///Input the x and y value of the item that needs a collision box, already sized to fit needs
        ///</summary>
        public void collisionBox(int x, int y)
        {
            Raylib.DrawRectangleLines(x, y, 12, 18, Color.BLACK);
        }

    }
}