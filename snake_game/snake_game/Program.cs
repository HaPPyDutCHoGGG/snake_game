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
            int x_1 = 1;
            int y_1 = 3;
            char sym_1 = '*';

            Draw(x_1,y_1,sym_1);

         
            
            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
