using System;
using System.Collections.Generic;
using System.Text;

namespace snake_game
{
    class Window_frame: Figure
    {
        public void Frame(int width, int height)
        {
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
        }
    }
}
