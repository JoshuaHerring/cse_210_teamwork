using Raylib_cs;
using System.Collections.Generic;
namespace tower_game
{
    public class TrackCreations
    {
        Collision collision = new Collision();
        Grid grid = new Grid();
        public Rectangle drawTrack(int x1, int xWidth, int y1, int yHeight)
        {
            Raylib.DrawRectangleRec(grid.selectBoxxes(x1, xWidth, y1, yHeight), Color.BEIGE);
            return collision.returnRectangle(x1,xWidth, y1 ,yHeight);
        }
        public void drawTrackList(List<Rectangle> Track)
        {
            for(int x = 0; x <= Track.Count -1; x++)
            {
                Raylib.DrawRectangleRec(Track[x], Color.BEIGE);
            }
        }
        public List<Rectangle> track1()
        {
            List<Rectangle> list = new List<Rectangle>()
            {
            grid.selectBoxxes(Immutables.x0, 400, Immutables.yE, 100),
            grid.selectBoxxes(Immutables.x4, 100, Immutables.yE, 200),
            grid.selectBoxxes(Immutables.x4, 400, Immutables.yG, 100),
            grid.selectBoxxes(Immutables.x7, 100, Immutables.yC, 400),
            grid.selectBoxxes(Immutables.x7, 500, Immutables.yB, 100)
            };
            return list;
        }
    }
}