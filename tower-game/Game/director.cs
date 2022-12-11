using Raylib_cs;
namespace tower_game
{
    public class Director
    {
        VideoServices videoServices = new VideoServices();
        Grid grid = new Grid();
        TrackCreations trackCreation = new TrackCreations();
        MouseServices mouseServices = new MouseServices();
        Placement placement = new Placement();
        Enemy enemy = new Enemy();
        public void startGame()
        {
            Rectangle location;

            location.x = Immutables.x0;
            location.y = Immutables.yE;
            location.height = 100;
            location.width = 100;

            videoServices.createWindow("DNHDNDTD");
            while(!Raylib.WindowShouldClose())
            {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            // trackCreation.track1();
            trackCreation.drawTrackList(trackCreation.track1());
            mouseServices.hoverHighlight();
            videoServices.GUI();
            placement.picturePlacement();
            placement.drawPictures();
            grid.drawGrid();
            videoServices.drawSprite(location, "dragon");
            location = enemy.navigate(grid.rectangleList() ,location);

            
            Raylib.EndDrawing();
            }
        }
    }
}