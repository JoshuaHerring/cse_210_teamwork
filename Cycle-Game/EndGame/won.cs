using Raylib_cs;
namespace Cycle_Game
{
    ///<summary>handles the winner of the game</summary>
    public class Won
    {
        ///<summary> Draws the winner to the screen in a sentence</summary>
        public void winner(string winner)
        {
            Raylib.DrawText($"The Winner is {winner}", 300, 200, 40, Raylib_cs.Color.BLACK);
        }
    }
}