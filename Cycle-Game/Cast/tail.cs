using System.Collections.Generic;

namespace Cycle_Game
{
    public class Tail : Cast
    {
        public List<Coords.coordinates> addTailSegment(Coords.coordinates coords, List<Coords.coordinates> coordList)
        {
            if( coordList.Contains(coords))
            {
                return coordList;
            }
            else
            {
                coordList.Add(coords);
                return coordList;
            }
        }
    }
}