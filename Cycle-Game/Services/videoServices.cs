using Raylib_cs;

namespace Cycle_Game
{
    public class VideoServices
    {
        public void openScreen(string name)
        {
            Raylib.InitWindow(1000, 700, name);
        }
    }
}