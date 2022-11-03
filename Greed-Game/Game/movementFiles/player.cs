// Michael

using System;
using Raylib_cs;

namespace Greed_Game
{
    public class Player : Movement
    {

        ///<summary>
        ///Detects the right button press and increments the block dowm
        ///</summary>
        private int rightButton(int x)
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                moveRight(x);
            }

            return x;
        }

        ///<summary>
        ///Detects the left button press and increments the block left
        ///</summary>
        private int leftButton(int x)
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                moveLeft(x);
            }

            return x;
        }

        ///<summary>
        ///Detects the down button press and increments the block down
        ///</summary>
        private int downButton(int y)
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
            {
                moveDown(y);
            }

            return y;
        }

        ///<summary>
        ///Detects the up button press and incremets the block up
        ///</summary>
        private int upBotton(int y)
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                moveUP(y);
            }

            return y;
        }
    }
}