using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.SetBufferSize(Console.LargestWindowWidth, Console.LargestWindowHeight);


            /*
            var width = 200;
            var height = 50;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            */

            /* 
             //Window frame
             Horizontal_Line hor_line_down = new Horizontal_Line(0, Console.WindowWidth - 1, Console.WindowHeight - 1, '█');
             Horizontal_Line hor_line_up = new Horizontal_Line(0, Console.WindowWidth - 1, 0, '█');
             Vertical_Line ver_line_left = new Vertical_Line(0, Console.WindowHeight - 1, 0, '█');
             Vertical_Line ver_line_right = new Vertical_Line(0, Console.WindowHeight - 1, Console.WindowWidth - 1, '█');
             hor_line_down.Draww();
             hor_line_up.Draww();
             ver_line_left.Draww();
             ver_line_right.Draww();
            */

            //snake
            Point p = new Point(2, 2, '*');
            snake snake = new snake(p, 4, Direction.RIGHT);
            snake.Draww();
            snake.Move();

            while (true)
            {
                
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.conrols(key.Key);
                }
                
                Thread.Sleep(50);
                snake.Move();
            }

            Console.ReadLine(); 

        }     
    }
}
