using Raylib_cs;
namespace tower_game
{
    public class Collision
    {
        public Rectangle returnRectangle(int x1, int x2, int y1, int y2)
        {
            if(y1 == 0)
            {
                y2 += 100;
            }
            else if(y1 == y2)
            {
                y2 = 100;
            }

            if(x1 == 0)
            {
                x2 += 100;
            }
            else if(x1 == x2)
            {
                x2 = 100;
            }
            Rectangle coordinate = new Rectangle(x1, y1, x2, y2);
            return coordinate;
        }
    }
}