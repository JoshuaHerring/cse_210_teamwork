using Raylib_cs;
using System.Collections.Generic;
namespace tower_game
{
    public class Grid
    {
        public void drawGrid()
        {
            for(int x = 0; x <= 1200; x += Immutables.gridSize)
            {
                Raylib.DrawLine(x, 0, x, Immutables.windowHeight, Color.BLACK);
            }
            for(int y = 0; y <= 900; y += Immutables.gridSize)
            {
                Raylib.DrawLine(0, y, Immutables.windowWidth, y, Color.BLACK);
            }
            drawLettersGrid();
        }
        private void drawLettersGrid()
        {
            for(int x = 0; x <= 1200; x += Immutables.gridSize)
            {
                int number = x / 100;
                string text;
                text =  number.ToString();
                Raylib.DrawText($"{text}", x+80, 10, 20, Color.BLUE);
            }
            for(int y = 0; y <= 800; y += Immutables.gridSize)
            {
                int number = y / 100;
                Raylib.DrawText($"{Immutables.letters[number]}", 10, y + 80, 20, Color.BLUE);
            }
        }
        public Rectangle selectBox(int x, int y)
        {
            Rectangle coordinate = new Rectangle(x, y, 100, 100);
            return coordinate;
        } 
        public Rectangle selectBoxxes(int x1, int x2, int y1, int yWidth)
        {
            // if(y1 == 0)
            // {
            //     y2 += 100;
            // }
            // else if(y1 == y2)
            // {
            //     y2 = 100;
            // }
            // else
            //     y2 -= y1;

            // if(x1 == 0)
            // {
            //     x2 += 100;
            // }
            // else if(x1 == x2)
            // {
            //     x2 = 100;
            // }
            
            Rectangle coordinate = new Rectangle(x1, y1, x2, yWidth);
            return coordinate;
        }

        public List<Rectangle> rectangleList()
        {
            List<Rectangle> rectangleList = new List<Rectangle>();
            for(int x = 0; x <= 1100; x += 100)
            {
                for(int y = 0; y <= 8; y++)
                {
                    rectangleList.Add(selectBox(x, Immutables.yCoords[y]));
                }
            }
            return rectangleList;
        }
    }
}