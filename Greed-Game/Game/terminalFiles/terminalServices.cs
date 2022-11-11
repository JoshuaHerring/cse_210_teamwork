// Josh is doing this one
using System;
using Raylib_cs;

namespace Greed_Game
{
    public class TerminalServices
    {

        FallingObjects fallingObjects = new FallingObjects();
        Movement movement = new Movement();
        Collision collision = new Collision();

        ///<summary> 
        ///creates a screen with proper size and the given name
        ///</summary>
        public void createScreen(string name)
        {
            Raylib.InitWindow(1000, 700, name);
        }
        
    }
}