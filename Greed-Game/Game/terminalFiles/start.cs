// Josh is doing this
using System;
using Raylib_cs;

namespace Greed_Game
{
    ///<summary>Displayes the start game screen</summary>
    public class Start : TerminalServices
    {
        ///<summary>Displayes the start game screen</summary>
        public void startGameScreen()
        {
            createScreen("Start Greed");
            Raylib.SetExitKey(KeyboardKey.KEY_ENTER);
            while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawText("Press enter to start", 225, 300, 50, Color.BLUE);
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}