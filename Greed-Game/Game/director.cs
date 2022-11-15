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

        public void startGame()
        {
            start.startGameScreen();
            List<List<FallingObjects.coords>> rowsOfRocks = new List<List<FallingObjects.coords>>();
            rowsOfRocks = fallingObjects.generateRows();
            

            terminalServices.createScreen("Greed");
            Raylib.SetTargetFPS(60);

            int x = 500;
            int y = 670;
            int time = 0;
            while (!Raylib.WindowShouldClose())
            {
                int seconds = time/60;
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                x = player.movingPlayerX(x, y, "#");
                Rectangle billyBob = collision.collisionBox(x, y, 12, 18);

                if (seconds >= 0)
                {
                    for (int i = 0; i < rowsOfRocks[0].Count; i++)
                    {
                        List<FallingObjects.coords> row = rowsOfRocks[0];
                        row[i] = fallingObjects.fallingSprite(row[i], "[]");
                    }
                }

                if (seconds >= 3)
                {
                    for (int i1 = 0; i1 < rowsOfRocks[0].Count; i1++)
                    {
                        List<FallingObjects.coords> row = rowsOfRocks[1];
                        row[i1] = fallingObjects.fallingSprite(row[i1], "[]");
                    }
                }

                // coords = terminalServices.fallingSprite(coords, "[]");
                // Rectangle bob = collision.collisionBox(coords.x, coords.y, 10, 18);
                // if(Raylib.CheckCollisionRecs(bob, billyBob))
                // {
                //     terminalServices.createScreen("BLOB");
                // }
                Raylib.EndDrawing();
                time++;
            }
        }
    }
}