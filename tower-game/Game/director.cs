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
            // trackCreation.track1();
            trackCreation.drawTrackList(trackCreation.track1());
            mouseServices.hoverHighlight();
            grid.drawGrid();
            // videoServices.drawSprite(grid.selectBox(415, 515), "dragon");
            Raylib.EndDrawing();
            }
        }
    }
}