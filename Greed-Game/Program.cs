using System;
using Raylib_cs;
namespace Greed_Game
{
    public class Program
    {
        private static void Main(string[] args)
        {
             Raylib.InitWindow(800, 600, "Greed");

             while (!Raylib.WindowShouldClose())
             {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);
                Raylib.DrawText("Hello World", 100, 250, 20, Color.GOLD);



                Raylib.EndDrawing();
             }
             Raylib.CloseWindow();
        }
    }
}