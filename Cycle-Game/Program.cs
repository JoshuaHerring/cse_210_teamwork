namespace Cycle_Game
{
    ///<summary>entry point of the program</summary>
    public class Program
    {
        private static void Main(string[] args)
        {
            Director director = new Director();
            director.start_game();
        }
    }
}