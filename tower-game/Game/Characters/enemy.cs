using System.Collections.Generic;
using Raylib_cs;
namespace tower_game
{
    public class Enemy
    {
        VideoServices videoServices = new VideoServices();
        //     List<Rectangle> list = new List<Rectangle>()
        //     {
        //     grid.selectBoxxes(Immutables.x0, 400, Immutables.yE, 100),
        //     grid.selectBoxxes(Immutables.x4, 100, Immutables.yE, 200),
        //     grid.selectBoxxes(Immutables.x4, 400, Immutables.yG, 100),
        //     grid.selectBoxxes(Immutables.x7, 100, Immutables.yC, 400),
        //     grid.selectBoxxes(Immutables.x7, 500, Immutables.yB, 100)
        //     };
        //     return list;
        // what it is, pathing(rectangles), stats

        ///<summary> List of two int</summary>
        public Rectangle navigate(List<Rectangle> trackList, Rectangle location)
        {
            int trackListLength = trackList.Count;
            for(int i = 0; i >= trackListLength; i++)
            {
                
            }

            return location;
        }

    }
}