using System;
using System.Collections.Generic;
using System.Text;

namespace snake_game
{
    class Vertical_Line: Figure
    {
        
        public Vertical_Line(int y_lower, int y_upper, int static_x, char sym) 
        {
            pList = new List<Point>();
            for (int y = y_lower; y <= y_upper; y++) {
                Point p = new Point(static_x, y, sym);
                pList.Add(p);
            }
        }        
    }
}
