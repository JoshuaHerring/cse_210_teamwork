using Raylib_cs;
namespace Cycle_Game
{
    public class Won
    {
        public void winner(string winner)
        {
            Raylib.DrawText($"The Winner is {winner}", 300, 200, 40, Raylib_cs.Color.BLACK);
        }
    }
}