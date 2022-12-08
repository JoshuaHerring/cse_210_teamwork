using Raylib_cs;
namespace tower_game
{
    public class VideoServices
    {
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
            Raylib.DrawTexture(dragon, x, y, Color.RAYWHITE);
        }
    }
}