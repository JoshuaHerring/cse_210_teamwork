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
    }
}