using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace snake_game
{
    class snake: Figure
    {
        public Direction direction;
        public snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++) {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = get_Next_point();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point get_Next_point() 
        {
            Point head = pList.Last();
            Point next_point = new Point(head);
            next_point.Move(1, direction);
            return next_point;
        }
    }
}
