using System;
using Raylib_cs;

namespace Greed_Game
{
    public class Director
    {
            TerminalServices terminalServices = new TerminalServices();
            Start start = new Start();
            Player player = new Player();
            Collision collision = new Collision();
        public void startGame()
        {
            start.startGameScreen();
            TerminalServices.coords coords = new TerminalServices.coords();
            coords.x = Raylib.GetRandomValue(0, 988);
            coords.y = 0;
            terminalServices.createScreen("Greed");
            Raylib.SetTargetFPS(60);
            int x = 500;
            int y = 670;
            while (!Raylib.WindowShouldClose())
            {
                Raylib.DrawFPS(200, 300);
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                coords = terminalServices.fallingSprite(coords, "[]");
                Rectangle bob = collision.collisionBox(coords.x, coords.y, 10, 18);
                // y = player.movingPlayerY(x, y, "#");
                x = player.movingPlayerX(x, y, "#");
                Rectangle billyBob = collision.collisionBox(x, y, 12, 18);
                if(Raylib.CheckCollisionRecs(bob, billyBob))
                {
                    terminalServices.createScreen("BLOB");
                }
                Raylib.EndDrawing();
            }
        }
    }
}