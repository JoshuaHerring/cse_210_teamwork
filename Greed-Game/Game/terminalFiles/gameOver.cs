// Josh is doing this
using System;
using Raylib_cs;

namespace Greed_Game
{
        ///<summary>displays the game over screen</summary>
    public class gameOver : TerminalServices
    {
        ///<summary>displays the game over screen</summary>
        public void gameEndScreen()
        {
            createScreen("Game Over");
            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText("Game Over press esc to exit", 125, 300, 50, Color.BLUE);
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}