using Raylib_cs;
namespace Cycle_Game
{
    ///<summary>Handles the cycle for the game</summary>
    public class Cycle
    {
        /// <summary>Draws the head of the snake at the given coords</summary>
        public void draw_head(Coords.coordinates coords, Raylib_cs.Color color)
        {
            Raylib.DrawText("@", coords.x, coords.y, 20, color);
        }
    }
}