namespace Cycle_Game
{
    ///<summary>Handles the movement of the head coords using the action keys functions</summary>
    public class Movement : Action
    {
        ///<summary> Handles the amount of which the character will move based on the set direction</summary>
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
        ///<summary> Changes the characters desired direction depending on the pressed  of "wasd"</summary>
        public string changeDirectionWASD(string direction)
        {
            direction = wPressed(direction);
            direction = aPressed(direction);
            direction = sPressed(direction);
            direction = dPressed(direction);
            return direction;
        }
        ///<summary> Changes the characters desired direction depending on the pressed key "ijkl"</summary>
        public string changeDirectionIJKL(string direction)
        {
             direction = iPressed(direction);
            direction = jPressed(direction);
            direction = kPressed(direction);
            direction = lPressed(direction);
            return direction;
        }

        
    }
}