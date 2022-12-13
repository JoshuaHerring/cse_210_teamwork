using Raylib_cs;
using System.Collections.Generic;
namespace tower_game
{
    public class VideoServices
    {
        Grid grid = new Grid();
        public void createWindow(string name)
        {
            Raylib.InitWindow(Immutables.windowWidth, Immutables.windowHeight, name);
        }

        public void startDrawing()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Immutables.backroundColor);
        }

        public unsafe void drawSprite(Rectangle location, string name)
        {
            int x = (int) location.x;
            int y = (int)location.y;
            Texture2D dragon = Raylib.LoadTexture($"Game/images/{name}.png");
            Raylib.DrawTexture(dragon, x + 17, y + 17, Color.WHITE);
        }

        public void drawSprites(List<Enemy.enemy> enemies)
        {
            int length = enemies.Count - 1;

            for(int i = 0; i <= length; i++)
            {
                Enemy.enemy currentEnemy = enemies[i];
                drawSprite(currentEnemy.location, "enemy");

                // Raylib.DrawRectangleLines((int)currentEnemy.collision.x, (int)currentEnemy.collision.y, 52, 60, Color.PURPLE);

                // Raylib.rawRectangleLines((int)location.x + 23, (int)location.y+20, 52, 60, Color.PURPLE);

            }
        }

        public void GUI()
        {
            drawSprite(grid.selectBox(Immutables.x5, Immutables.yI), "dragon");
        }
        
    }
}