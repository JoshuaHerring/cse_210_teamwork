using System;
using Raylib_cs;

namespace Greed_Game
{
    public class Director
    {
        public void startGame()
        {
            TerminalServices terminalServices = new TerminalServices();
            Start start = new Start();
            start.startGameScreen();
            terminalServices.createScreen("Greed");
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                Raylib.DrawCircle(200, 200, 20, Color.BEIGE);

                Raylib.EndDrawing();
            }
        }
    }
}