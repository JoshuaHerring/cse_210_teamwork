// Josh is doing this one
using System;
using Raylib_cs;

namespace Greed_Game
{
    public class TerminalServices
    {
        public struct coords
        {
            public int x;
            public int y;
        }
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
        public coords fallingSprite(coords coordinates, string character)
        {
            movement.drawSprite(character, coordinates.x, coordinates.y, Color.BLUE);
            coordinates.y = fallingObjects.down(coordinates.y);

            return coordinates;
        }
        
    }
}