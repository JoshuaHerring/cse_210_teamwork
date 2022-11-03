// Michael

using System;
using Raylib_cs;

namespace Greed_Game
{
    public class Movement
    {
        ///<summary>
        ///Inputs the x location of the block and moves it right
        ///</summary>
        public int moveRight(int x)
        {
            x++;
            return x;
        }

        ///<summary>
        ///Inputs the x location of the block and moves it left
        ///</summary>
        public int moveLeft(int x)
        {
            x--;
            return x;
        }

        ///<summary>
        ///Inputs the y location of the block and moves it down
        ///</summary>
        public int moveDown(int y)
        {
            y--;
            return y;
        }

        ///<summary>
        ///Inputs the y location of the block and moves it up
        ///</summary>
        public int moveUP(int y)
        {
            y++;
            return y;
        }

        ///<summary>
        ///Draws the sprite, allows for input to change the shape
        ///<para>
        ///Input the x value of the sprite, inputs the y value of the sprite, input the color of the Sprite
        ///</para>
        ///</summary>
        public void drawSprite(string character, int xPos, int yPos, Raylib_cs.Color color)
        {
            Raylib.DrawText(character, xPos, yPos, 10, color);
        }
    }
}