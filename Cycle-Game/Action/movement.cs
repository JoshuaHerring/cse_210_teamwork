namespace Cycle_Game
{
    public class Movement : Action
    {
        ///<summary> Changes the characters desired direction depending on the pressed key</summary>
        public Coords.coordinates move(string direction, Coords.coordinates coords)
        {

            if(direction == "right")
            {
                coords.x += Immutables.moveRate;
            }

            else if(direction == "left")
            {
                coords.x -= Immutables.moveRate;
            }

            else if(direction == "up")
            {
                coords.y -= Immutables.moveRate;
            }

            else if(direction == "down")
            {
                coords.y += Immutables.moveRate;
            }

            return coords;
        }

        public string changeDirection(string direction)
        {
            direction = wPressed(direction);
            direction = aPressed(direction);
            direction = sPressed(direction);
            direction = dPressed(direction);
            return direction;
        }

        public string changeDirection2(string direction)
        {
             direction = iPressed(direction);
            direction = jPressed(direction);
            direction = kPressed(direction);
            direction = lPressed(direction);
            return direction;
        }

        
    }
}