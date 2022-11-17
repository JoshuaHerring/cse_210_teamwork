// Michael

using System;
using Raylib_cs;

namespace Greed_Game
{
    ///<summary>Handles the movement of the player by inputed keys</summary>
    public class Player : Movement
    {
        Collision collision = new Collision();


        ///<summary>
        ///Detects the right button press and increments the block dowm
        ///</summary>
        public int rightButton(int x)
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
        public int leftButton(int x)
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
        public int downButton(int y)
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
        public int upBotton(int y)
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
            {
                moveUP(y);
            }

            return y;
        }
        ///<summary> Moves the player on the y axis. <para>returns the processing y coordinate</para></summary>
        public int movingPlayerY(int x, int y, string character)
        {
            drawSprite(character, x, y, Color.WHITE);
            collision.collisionBox(x, y, 12, 18);
            if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                y = moveDown(y);
            if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                y = moveUP(y);

            return y;
        }
        ///<summary> Moves the player on the x axis. <para>returns the processing x coordinate</para></summary>
        public int movingPlayerX(int x, int y, string character)
        {
            drawSprite(character, x, y, Color.WHITE);
            collision.collisionBox(x, y, 12, 18);
            if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                x = moveLeft(x);
            if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                x = moveRight(x);

            if(x <= 0)
            {
                x = 0;
            }
            if(x >= 988)
            {
                x = 988;
            }
            return x;
        }
    }
}