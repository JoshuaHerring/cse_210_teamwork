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
        Movement movement = new Movement();
        Tower tower = new Tower();

        public void startGame()
        {
            int time = 0;
            // Immutables.enemies = enemy.addEnemy(Immutables.enemies);

            Rectangle useless = new Rectangle(-100, -100, 0 ,0);
            Immutables.pictureLocations.Add(useless, "");

            Raylib.SetTargetFPS(60);
            videoServices.createWindow("DNHDNDTD");
            while(!Raylib.WindowShouldClose())
            {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            
            enemy.validateEnemyAddition(time);
            
            trackCreation.drawTrackList(trackCreation.track1());
            mouseServices.hoverHighlight();
            videoServices.GUI();
            placement.picturePlacement();
            placement.drawPictures();
            grid.drawGrid();
            videoServices.drawSprites(Immutables.enemies);
            // videoServices.drawSprite(location, "enemy");


            // location = movement.navigate(trackCreation.track1() ,location);
            Immutables.enemies = movement.navigateEnemies(Immutables.enemies, trackCreation.track1());

            // Enemy.enemy badie = Immutables.enemies[0];
            tower.towerCreation();

            time++;
            Raylib.EndDrawing();
            }
        }
    }
}