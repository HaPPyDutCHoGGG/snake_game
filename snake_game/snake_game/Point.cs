using System;
using System.Collections.Generic;
using System.Text;

namespace snake_game
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x += offset;
            if (direction == Direction.LEFT)
                x -= offset;
            if (direction == Direction.UP)
                y += offset;
            if (direction == Direction.DOWN)
                y -= offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
