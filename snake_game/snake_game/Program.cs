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
            //Window frame

            var width = 100;
            var height = 50;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
                
            Horizontal_Line hor_line_down = new Horizontal_Line(0, Console.WindowWidth - 1, Console.WindowHeight - 1, '█');
            Horizontal_Line hor_line_up = new Horizontal_Line(0, Console.WindowWidth - 1, 0, '█');
            Vertical_Line ver_line_left = new Vertical_Line(0, Console.WindowHeight - 1, 0, '█');
            Vertical_Line ver_line_right = new Vertical_Line(0, Console.WindowHeight - 1, Console.WindowWidth - 1, '█');
            hor_line_down.Draww();
            hor_line_up.Draww();
            ver_line_left.Draww();
            ver_line_right.Draww();

            //snake
            Point p = new Point(5, 4, '*');
            snake snake = new snake(p, 4, Direction.RIGHT);
            snake.Draww();
            snake.Move();

            //controls
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.UP;
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine(); 

        }     
    }
}
