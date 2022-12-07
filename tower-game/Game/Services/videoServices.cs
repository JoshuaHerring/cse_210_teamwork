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
    }
}