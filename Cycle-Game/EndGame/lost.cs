using Raylib_cs;
namespace Cycle_Game
{
    ///<summary>Handles the loser of the game</summary>
    public class Lost
    {
        ///<summary> Draws the loser to the screen in a sentence</summary>
        public void loser(string loser)
            {
                Raylib.DrawText($"The Loser is {loser}", 300, 400, 40, Raylib_cs.Color.BLACK);
            }
    }
}