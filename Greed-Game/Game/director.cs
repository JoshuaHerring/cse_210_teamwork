using System;
using Raylib_cs;

namespace Greed_Game
{
    public class Director
    {
            TerminalServices terminalServices = new TerminalServices();
            Start start = new Start();
        public void startGame()
        {
            start.startGameScreen();
            terminalServices.createScreen("Greed");
            int y = 0;
            Raylib.SetTargetFPS(60);
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                y = terminalServices.fallingSprite(y);

                Raylib.EndDrawing();
            }
        }
    }
}