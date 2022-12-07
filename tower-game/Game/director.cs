using Raylib_cs;
namespace tower_game
{
    public class Director
    {
        VideoServices videoServices = new VideoServices();
        Grid grid = new Grid();
        TrackCreations trackCreation = new TrackCreations();
        MouseServices mouseServices = new MouseServices();
        public void startGame()
        {
            videoServices.createWindow("DNHDNDTD");
            while(!Raylib.WindowShouldClose())
            {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            // mouseServices.hoverHighlight();
            trackCreation.track1();
            grid.drawGrid();
            Raylib.EndDrawing();
            }
        }
    }
}