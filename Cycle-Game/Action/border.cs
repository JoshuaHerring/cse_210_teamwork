using Raylib_cs;
using System.Collections.Generic;
namespace Cycle_Game
{
    ///<summary> Border handles the logic of the player reaching the edge of the screen</summary>
    public class Border : Collision
    {
        ///<summary>When the head coords reach a side of the screen it moves the player to the opposite side of the screen</summary>
        public Coords.coordinates borderControl(Coords.coordinates head)
        {
            head = topBorder(head);
            head = bottomBorder(head);
            head = leftBorder(head);
            head = rightBorder(head);

            return head;
        }
         ///<summary> When the head coords reach the left of the screen it moves the head coords to the right</summary>
        private Coords.coordinates leftBorder(Coords.coordinates head)
        {
            if(head.x <= -20)
            {
                head.x = 1000;
            }
            return head;
        }
        ///<summary> When the head coords reach the right of the screen it moves the head coords to the left</summary>
        private Coords.coordinates rightBorder(Coords.coordinates head)
        {
            if(head.x >= 1020)
            {
                head.x = -20;
            }
            return head;
        }
        ///<summary> When the head coords reach the top of the screen it moves the head coords to the bottom</summary>
        private Coords.coordinates topBorder(Coords.coordinates head)
        {
            if(head.y <= -21)
            {
                head.y = 700;
            }
            return head;
        }
        ///<summary> When the head coords reach the bottom of the screen it moves the head coords to the top</summary>
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
