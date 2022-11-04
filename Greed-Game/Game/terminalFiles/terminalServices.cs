// Josh is doing this one
using System;
using Raylib_cs;

namespace Greed_Game
{
    public class TerminalServices
    {
        Movement movement = new Movement();
        FallingObjects fallingobjects = new FallingObjects();

        ///<summary> creates a screen iwth proper size and the given name</summary>
        public void createScreen(string name)
        {
            Raylib.InitWindow(1000, 700, name);
        }

        ///<summary> Generates a falling sprite to fall from the top of the screen to the bottom with a random x value
        ///<para> returns the processing y coordinate</para>
        ///</summary>
        public int fallingSprite(int y, int x, string character)
        {
            // int x = fallingobjects.randomNumber();
            // int x = 500;
            movement.drawSprite(character, x, y, Color.BLUE);
            y = fallingobjects.down(y);

            return y;
        }


    }
}