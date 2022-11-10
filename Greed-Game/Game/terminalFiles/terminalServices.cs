// Josh is doing this one
using System;
using Raylib_cs;

namespace Greed_Game
{
    public class TerminalServices
    {
        Movement movement = new Movement();
        FallingObjects fallingObjects = new FallingObjects();
        Collision collision = new Collision();

        ///<summary> 
        ///creates a screen with proper size and the given name
        ///</summary>
        public void createScreen(string name)
        {
            Raylib.InitWindow(1000, 700, name);
        }

        ///<summary> Generates a falling sprite to fall from the top of the screen to the bottom with a random x value
        ///<para> returns the processing y coordinate</para>
        ///</summary>
        public int fallingSprite(int y, string character)
        {
            // int x = fallingobjects.randomNumber();
            int x = 500;
            movement.drawSprite(character, x, y, Color.BLUE);
            collision.collisionBox(x, y, 12, 18);
            y = fallingObjects.down(y);

            return y;
        }

            // public void sprites()
            // {
            //     int y = 0;
            //     int x = fallingObjects.randomNumber();
            //     fallingSprite(y, "[]");
            // }
        
    }
}