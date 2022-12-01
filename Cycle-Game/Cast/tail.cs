using System.Collections.Generic;

namespace Cycle_Game
{
    ///<summary> handles the trail/tail location adding of the trail/tail </summary>
    public class Tail
    {
        //<summary> Adds the current location ot the list of segments in the tail</summary>
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