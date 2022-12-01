using Raylib_cs;
namespace Cycle_Game
{
    public class Action
    {
        ///<summary>Checks if the w key is down returns string "up" if it is</summary>
        public string wPressed(string direction)
        {
            if( Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
            direction = "up";
            }
                return direction;
        }
                ///<summary>Checks if the s key is down returns string "down" if it is</summary>
        public string sPressed(string direction)
        {
            if(Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                direction = "down";
            }
            return direction;
        }
                ///<summary>Checks if the a key is down returns string "left" if it is</summary>
        public string aPressed(string direction)
        {
            if(Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                direction = "left";
            }
            return direction;
        }
                ///<summary>Checks if the d key is down returns string "right" if it is</summary>
        public string dPressed(string direction)
        {
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                direction = "right";
            }
            return  direction;
        }

        ///Player 2 controls start here

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