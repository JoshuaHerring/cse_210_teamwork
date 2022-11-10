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
        public Rectangle collisionBox(int x, int y, int width, int height)
        {
            Rectangle billy = new Rectangle(x, y, width, height);
            Raylib.DrawRectangleLines(x, y, width, height, Color.BLACK);
            return billy;
        }



    }
}