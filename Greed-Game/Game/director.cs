using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Greed_Game
{
    public class Director
    {
            TerminalServices terminalServices = new TerminalServices();
            Start start = new Start();
            gameOver gameOver = new gameOver();
            Player player = new Player();
            Collision collision = new Collision();
            FallingObjects fallingObjects = new FallingObjects();
            Score score = new Score();

        public void startGame()
        {
            // This specific commit is a safe checkpoint for the games progress
            start.startGameScreen();
            List<List<FallingObjects.coords>> rowsOfRocks = new List<List<FallingObjects.coords>>();
            rowsOfRocks = fallingObjects.generateRows();
            

            terminalServices.createScreen("Greed");
            int fps = 60*2;
            Raylib.SetTargetFPS(fps);

            int x = 500;
            int y = 670;
            int time = 0;
            int points = 10;
            while (!Raylib.WindowShouldClose())
            {
                int seconds = time/fps;
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
                            points = score.pointLost(points);
                        }
                        if(coords.y >= 700)
                        {
                            row[i] = collision.reset(row[i]);
                        }
                    }
                }

                if (seconds >= 2)
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
                            row[i1] = collision.reset(row[i1]);
                            points = score.pointLost(points);
                        }
                        if(coords.y >= 700)
                        {
                            row[i1] = collision.reset(row[i1]);
                        }
                    }
                }

                if (seconds >= 4)
                {
                    for (int i2 = 0; i2 < rowsOfRocks[2].Count; i2++)
                    {
                        List<FallingObjects.coords> row = rowsOfRocks[2];
                        row[i2] = fallingObjects.fallingSprite(row[i2], "[]");

                        FallingObjects.coords coords = row[i2];
                        collision.collisionBox(coords.x, coords.y, 12,18);
                        rockCollision.x = coords.x;
                        rockCollision.y = coords.y;
                        if(Raylib.CheckCollisionRecs(playerCollsion, rockCollision))
                        {
                            row[i2] = collision.reset(row[i2]);
                            points = score.pointLost(points);
                        }
                        if(coords.y >= 700)
                        {
                            row[i2] = collision.reset(row[i2]);
                        }
                    }
                }


                Raylib.EndDrawing();
                time++;
            }
        }
    }
}