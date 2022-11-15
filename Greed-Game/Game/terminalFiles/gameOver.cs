// Josh is doing this
using System;
using Raylib_cs;

namespace Greed_Game
{
    public class gameOver : TerminalServices
    {
        public void gameEndScreen()
        {
            createScreen("Game Over");
            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText("Game Over press esc to exit", 225, 300, 50, Color.BLUE);
                Raylib.EndDrawing();
            }
        }
    }
}