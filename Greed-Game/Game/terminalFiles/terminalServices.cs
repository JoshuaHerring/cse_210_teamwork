// Josh is doing this one
using System;
using Raylib_cs;

namespace Greed_Game
{
    ///<summary>Handles the process of displaying screens</summary>
    public class TerminalServices
    {

        ///<summary> 
        ///creates a screen with proper size and the given name
        ///</summary>
        public void createScreen(string name)
        {
            Raylib.InitWindow(1000, 700, name);
        }
        
    }
}