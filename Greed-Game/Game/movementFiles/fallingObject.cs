// Michael

using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Greed_Game
{
    public class FallingObjects : Movement
    {
        TerminalServices terminalServices = new TerminalServices();
        TerminalServices.coords coords = new TerminalServices.coords();
        private List<TerminalServices.coords> generateRow()
        {
            List<TerminalServices.coords> row = new List<TerminalServices.coords>();
            for (int i = 0; i > Raylib.GetRandomValue(3, 12); i++)
            {
                coords.x = Raylib.GetRandomValue(0, 1000);
                coords.y = 0;
            row.Add(coords);
            }

            return row;
        }

        public List<List<TerminalServices.coords>> generateRows()
        {
            List<List<TerminalServices.coords>> rows = new List<List<TerminalServices.coords>>();
            for (int i = 0; i > 4; i++)
            {
                List<TerminalServices.coords> row = generateRow();
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