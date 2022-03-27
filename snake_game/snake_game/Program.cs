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
            //Window frame

            var width = 100;
            var height = 50;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
                
            Horizontal_Line hor_line_down = new Horizontal_Line(0, Console.WindowWidth - 1, Console.WindowHeight - 1, '█');
            hor_line_down.Draww();
            Horizontal_Line hor_line_up = new Horizontal_Line(0, Console.WindowWidth - 1, 0, '█');
            hor_line_up.Draww();
            Vertical_Line ver_line_left = new Vertical_Line(0, Console.WindowHeight - 1, 0, '█');
            ver_line_left.Draww();
            Vertical_Line ver_line_right = new Vertical_Line(0, Console.WindowHeight - 1, Console.WindowWidth - 1, '█');
            ver_line_right.Draww();

            //snake
            Point p = new Point(5, 4, '*');
            snake snake = new snake(p, 4, Direction.RIGHT);
            snake.Draww();




            Console.ReadLine(); 

        }     
    }
}
