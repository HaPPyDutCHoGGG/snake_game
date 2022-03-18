using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x_1 = 1;
            int y_1 = 3;
            char sym_1 = '*';

            Draw(x_1,y_1,sym_1);
            */

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 2;
            p2.y = 4;
            p2.sym = '#';
            p2.Draw();

            Console.ReadLine();
        }
        /*
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        */
    }
}
