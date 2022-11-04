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

        public int fallingSprite(int y)
        {
            // int x = fallingobjects.randomNumber();
            int x = 500;
            movement.drawSprite("[]", x, y, Color.BLUE);
            y = fallingobjects.down(y);

            return y;
        }



    }
}