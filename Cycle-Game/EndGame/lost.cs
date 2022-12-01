using Raylib_cs;
namespace Cycle_Game
{
    public class Lost
    {
        public void loser(string loser)
            {
                Raylib.DrawText($"The Loser is {loser}", 300, 400, 40, Raylib_cs.Color.BLACK);
            }
    }
}