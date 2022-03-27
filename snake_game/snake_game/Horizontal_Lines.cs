using System;
using System.Collections.Generic;
using System.Text;

namespace snake_game
{
    class Horizontal_Line: Figure
    {
       
        public Horizontal_Line(int x_left, int x_right, int static_y, char sym)
        {
            pList = new List<Point>();
            for (int x = x_left; x <= x_right; x++) {
                Point p = new Point(x, static_y, sym);
                pList.Add(p);
            }
        }
    }
}
