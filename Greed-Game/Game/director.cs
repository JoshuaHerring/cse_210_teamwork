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
            Score score = new Score();

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
            int points = 10;
            while (!Raylib.WindowShouldClose())
            {
                int seconds = time/60;
                Rectangle rockCollision = new Rectangle();
                rockCollision.width = 12;
                rockCollision.height = 18;

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                string printedPoints = $"Score: {points}";
                Raylib.DrawText(printedPoints, 100, 100, 20, Color.BLACK);

                x = player.movingPlayerX(x, y, "#");
                Rectangle playerCollsion = collision.collisionBox(x, y, 12, 18);

                if (seconds >= 0)
                {
                    for (int i = 0; i < rowsOfRocks[0].Count; i++)
                    {
                        List<FallingObjects.coords> row = rowsOfRocks[0];
                        row[i] = fallingObjects.fallingSprite(row[i], "[]");

                        FallingObjects.coords coords = row[i];
                        collision.collisionBox(coords.x, coords.y, 12,18);
                        rockCollision.x = coords.x;
                        rockCollision.y = coords.y;
                        if(Raylib.CheckCollisionRecs(playerCollsion, rockCollision))
                        {
                            row[i] = collision.reset(row[i]);
                            points--;
                        }
                    }
                }

                if (seconds >= 1)
                {
                    for (int i1 = 0; i1 < rowsOfRocks[1].Count; i1++)
                    {
                        List<FallingObjects.coords> row = rowsOfRocks[1];
                        row[i1] = fallingObjects.fallingSprite(row[i1], "[]");

                        FallingObjects.coords coords = row[i1];
                        collision.collisionBox(coords.x, coords.y, 12,18);
                        rockCollision.x = coords.x;
                        rockCollision.y = coords.y;
                        if(Raylib.CheckCollisionRecs(playerCollsion, rockCollision))
                        {
                            points = score.pointLost(points);
                        }
                    }
                }

                Raylib.EndDrawing();
                time++;
            }
        }
    }
}