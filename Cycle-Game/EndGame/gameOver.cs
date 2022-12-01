using Raylib_cs;
namespace Cycle_Game
{
    public class GameOver
    {
        VideoServices videoServices = new VideoServices();
        Won won = new Won();
        Lost lost = new Lost();

        public void endScreen(string winner, string loser)
        {
            videoServices.openScreen("Game Over");
             while(!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Raylib_cs.Color.RAYWHITE);
                won.winner(winner);
                lost.loser(loser);
                Raylib.EndDrawing();
            }
        }
    }
}