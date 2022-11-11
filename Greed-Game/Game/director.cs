using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Greed_Game
{
    public class Director
    {
            TerminalServices terminalServices = new TerminalServices();
            Start start = new Start();
            Player player = new Player();
            Collision collision = new Collision();
            FallingObjects fallingObjects = new FallingObjects();

            TerminalServices.coords coords = new TerminalServices.coords();
        public void startGame()
        {
            start.startGameScreen();
            List<List<int>> rows = new List<List<int>>();
            rows = fallingObjects.generateRows();
            
            coords.x = Raylib.GetRandomValue(0, 988);
            coords.y = 0;

            terminalServices.createScreen("Greed");
            Raylib.SetTargetFPS(60);

            int x = 500;
            int y = 670;
            
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                coords = terminalServices.fallingSprite(coords, "[]");
                Rectangle bob = collision.collisionBox(coords.x, coords.y, 10, 18);
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