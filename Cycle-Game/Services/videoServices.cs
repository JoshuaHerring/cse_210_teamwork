using Raylib_cs;
using System.Collections.Generic;

namespace Cycle_Game
{
    public class VideoServices
    {
        ///<summary>Creates a screen of proper size with the given name</summary>
        public void openScreen(string name)
        {
            Raylib.InitWindow(Immutables.width, Immutables.height, name);
        }

        /// <summary>Draws the head of the snake at the given coords</summary>
        public void draw_head(Coords.coordinates coords, Raylib_cs.Color color)
        {
            Raylib.DrawText("@", coords.x, coords.y, 20, color);
        }

        public void draw_tail(List<Coords.coordinates> coord_list, Raylib_cs.Color color)
        {
            int length = coord_list.Count;
            for(int i = 0; i < length; i++)
            {
                Coords.coordinates coords = coord_list[i];
                Raylib.DrawText("#", coords.x, coords.y, 20, color);
            }
        }
    }
}