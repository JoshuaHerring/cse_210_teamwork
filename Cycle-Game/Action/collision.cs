using Raylib_cs;
using System.Collections.Generic;
namespace Cycle_Game
{
    ///<summary>Handles the collision physics of the trails and the heads</summary>
    public class Collision : Movement
    {

        ///<summary>adds the current coordinate location to a list of collision boxes stored as rectangles</summary>
        public List<Rectangle> addCollision(Coords.coordinates coords, List<Rectangle> collisionBoxes)
        {
            Rectangle collision = new Rectangle(coords.x, coords.y, 14, 18);
            if(collisionBoxes.Contains(collision))
            {
                return collisionBoxes;
            }
            else
            {
                collisionBoxes.Add(collision);
                return collisionBoxes;
            }
        }
        ///<summary>Checks for collision between the head and the trails of both characters</summary>
        public bool checkCollision(Coords.coordinates coords, List<Rectangle> collisionBoxes)
        {
            Rectangle collision = new Rectangle(coords.x, coords.y, 14, 18);
            int length = collisionBoxes.Count;
            for(int i = 0; i < length; i++)
            {
                // Raylib.DrawRectangleRec(collisionBoxes[i], Raylib_cs.Color.BLACK);
                if(Raylib.CheckCollisionRecs(collision, collisionBoxes[i]))
                {
                    return true;
                }
            }

            return false;
        }
    }
}