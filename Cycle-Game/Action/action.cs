using Raylib_cs;
namespace Cycle_Game
{
    ///<summary>Handles the actions for the player</summary>
    public class Action
    {
        ///<summary>Checks if the i key is down returns string "up" if it is</summary>
        public string iPressed(string direction)
        {
            if( Raylib.IsKeyDown(KeyboardKey.KEY_I))
            {
            direction = "up";
            }
                return direction;
        }

        ///<summary>Checks if the k key is down returns string "down" if it is</summary>
        public string kPressed(string direction)
        {
            if(Raylib.IsKeyDown(KeyboardKey.KEY_K))
            {
                direction = "down";
            }
            return direction;
        }

        ///<summary>Checks if the j key is down returns string "left" if it is</summary>
        public string jPressed(string direction)
        {
            if(Raylib.IsKeyDown(KeyboardKey.KEY_J))
            {
                direction = "left";
            }
            return direction;
        }

        ///<summary>Checks if the l key is down returns string "right" if it is</summary>
        public string lPressed(string direction)
        {
            if(Raylib.IsKeyDown(KeyboardKey.KEY_L))
            {
                direction = "right";
            }
            return  direction;
        }


    }
}