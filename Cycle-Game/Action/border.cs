using Raylib_cs;
using System.Collections.Generic;
namespace Cycle_Game
{
    public class Border : Collision
    {
        public Coords.coordinates borderControl(Coords.coordinates head)
        {
            head = topBorder(head);
            head = bottomBorder(head);
            head = leftBorder(head);
            head = rightBorder(head);

            return head;
        }
        private Coords.coordinates leftBorder(Coords.coordinates head)
        {
            if(head.x <= -20)
            {
                head.x = 1000;
            }
            return head;
        }

        private Coords.coordinates rightBorder(Coords.coordinates head)
        {
            if(head.x >= 1020)
            {
                head.x = -20;
            }
            return head;
        }

        private Coords.coordinates topBorder(Coords.coordinates head)
        {
            if(head.y <= -21)
            {
                head.y = 700;
            }
            return head;
        }

        private Coords.coordinates bottomBorder(Coords.coordinates head)
        {
            if(head.y >= 701)
            {
                head.y = -20;
            }
            return head;
        }
    }
}
