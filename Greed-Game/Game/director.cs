using System;
using Raylib_cs;

namespace Greed_Game
{
    public class Director
    {
        public void startGame()
        {
            TerminalServices terminalServices = new TerminalServices();
            terminalServices.createScreen();

  
            while (!Raylib.WindowShouldClose())
            {
                Raylib.EndDrawing();

                Raylib.EndDrawing();
            }
        }
    }
}