using System;
using Raylib_cs;
namespace Greed_Game
{
    public class Program
    {
        private static void Main(string[] args)
        {
<<<<<<< HEAD
             Raylib.InitWindow(1000, 700, "Greed");

             while (!Raylib.WindowShouldClose())
             {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                Raylib.DrawText("Hello World", 100, 250, 20, Color.GOLD);



                Raylib.EndDrawing();
             }
             Raylib.CloseWindow();
=======
            Director director = new Director();
            director.startGame();
>>>>>>> 38925ff13c982f13ec90f67c1ba45813d8feb779
        }
    }
}