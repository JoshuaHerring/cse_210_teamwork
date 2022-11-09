// Michael

using System;
using Raylib_cs;

namespace Greed_Game
{
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

        public int movingPlayerY(int x, int y, string character)
        {
            drawSprite(character, x, y, Color.BLACK);
            collision.collisionBox(x, y);
            if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                y = moveDown(y);
            if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                y = moveUP(y);

            return y;
        }
        public int movingPlayerX(int x, int y, string character)
        {
            drawSprite(character, x, y, Color.BLACK);
            collision.collisionBox(x, y);
            if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                x = moveLeft(x);
            if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                x = moveRight(x);
            return x;
        }


    }
}