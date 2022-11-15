// Michael

using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Greed_Game
{
    public class FallingObjects : Movement
    {
        Movement movement = new Movement();
            public struct coords
        {
            public int x;
            public int y;
        }
        coords coordinates = new coords();
        private List<coords> generateRow()
        {
            List<coords> row = new List<coords>();
            for (int i = 0; i < Raylib.GetRandomValue(6, 12); i++)
            {
                coordinates.x = Raylib.GetRandomValue(0, 988);
                coordinates.y = Raylib.GetRandomValue(0, 100);
            row.Add(coordinates);
            }

            return row;
        }

        public List<List<coords>> generateRows()
        {
            List<List<coords>> rows = new List<List<coords>>();
            for (int i = 0; i < 3; i++)
            {
                List<coords> row = generateRow();
                rows.Add(row);

            }
            return rows;
        }

        ///<summary> Generates a falling sprite to fall from the top of the screen to the bottom with a random x value
        ///<para> returns the processing coordinates in a struct</para>
        ///</summary>
        public coords fallingSprite(coords coordinates, string character)
        {
            movement.drawSprite(character, coordinates.x, coordinates.y, Color.BLUE);
            coordinates.y = down(coordinates.y);

            return coordinates;
        }
        public int down(int y)
        {
            y = moveDown(y);
            return y;
        }
    }
}