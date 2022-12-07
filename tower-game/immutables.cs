using Raylib_cs;
using System.Collections.Generic;
namespace tower_game
{
    public class Immutables
    {
        public static int mouseWidth = 1;
        public static int mouseHeight = 1;
        public static int windowWidth = 1200;
        public static int windowHeight = 900;
        public static int gridSize = 100;
        public static Raylib_cs.Color backroundColor = Color.WHITE;
        public static Color clearGreen = new Color(50, 255, 30, 100);
        public static Color clearRed = new Color(255, 0, 0, 100);
        public static int x0 = 000;
        public static int x1 = 100;
        public static int x2 = 200;
        public static int x3 = 300;
        public static int x4 = 400;
        public static int x5 = 500;
        public static int x6 = 600;
        public static int x7 = 700;
        public static int x8 = 800;
        public static int x9 = 900;
        public static int x10 = 1000;
        public static int x11 = 1100;

        public static int yA = 000;
        public static int yB = 100;
        public static int yC = 200;
        public static int yD = 300;
        public static int yE = 400;
        public static int yF = 500;
        public static int yG = 600;
        public static int yH = 700;
        public static int yI = 800;
        public static List<string> letters = new List<string>()
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I"
        };
        public static List<int> yCoords = new List<int>()
        {
            yA, yB, yC, yD, yE, yF, yG, yH, yI
        };
        public static List<int> numbers = new List<int>()
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11
        };
    }
}