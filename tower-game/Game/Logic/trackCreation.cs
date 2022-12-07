using Raylib_cs;
namespace tower_game
{
    public class TrackCreations
    {
        Collision collision = new Collision();
        Grid grid = new Grid();
        public Rectangle drawTrack(int x1, int x2, int y1, int y2)
        {
            Raylib.DrawRectangleRec(grid.selectBoxxes(x1, x2, y1, y2), Color.BEIGE);
            return collision.returnRectangle(x1,x2, y1 ,y2);
        }
        public void track1()
        {
            drawTrack(Immutables.x0, Immutables.x4, Immutables.yE, Immutables.yE);
            drawTrack(Immutables.x6, Immutables.x6, Immutables.yE, Immutables.yG);
        }
    }
}