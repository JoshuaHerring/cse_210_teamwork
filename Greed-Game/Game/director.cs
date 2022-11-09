using System;
using Raylib_cs;

namespace Greed_Game
{
    public class Director
    {
            TerminalServices terminalServices = new TerminalServices();
            Start start = new Start();
            Player player = new Player();
        public void startGame()
        {
            start.startGameScreen();
            terminalServices.createScreen("Greed");
            Raylib.SetTargetFPS(60);
            int x = 500;
            int y = 670;
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
            // y =terminalServices.fallingSprite(y, "#");
                // y = player.movingPlayerY(x, y, "#");
                x = player.movingPlayerX(x, y, "#");
                Raylib.EndDrawing();
            }
        }
    }
}