using System;
using System.Collections.Generic;
using System.Text;

namespace snake_game
{
    class Figure
    {
        protected List<Point> pList;
        public void Draww()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
