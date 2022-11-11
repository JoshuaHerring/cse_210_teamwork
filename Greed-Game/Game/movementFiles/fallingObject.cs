// Michael

using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Greed_Game
{
    public class FallingObjects : Movement
    {
        private List<int> generateRow()
        {
            List<int> row = new List<int>();
            for (int i = 0; i > Raylib.GetRandomValue(3, 12); i++)
            {
            row.Add(Raylib.GetRandomValue(0, 1000));
            row.Add(0);
            }

            return row;
        }

        public List<List<int>> generateRows()
        {
            List<List<int>> rows = new List<List<int>>();
            for (int i = 0; i > 4; i++)
            {
                List<int> row = generateRow();
                rows.Add(row);

            }
            return rows;
        }
        public int down(int y)
        {
            y = moveDown(y);
            return y;
        }

        public int randomNumber()
        {
            Random rnd = new Random();
            int x = rnd.Next(0, 1001);

            return x;
        }
    }
}