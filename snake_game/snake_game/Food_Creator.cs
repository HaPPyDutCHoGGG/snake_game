using System;
using System.Collections.Generic;
using System.Text;

namespace snake_game
{
    class Food_Creator
    {
        int map_width;
        int map_height;
        char sym;
        Random random = new Random();

        public Food_Creator (int map_width, int map_height, char sym)
        {
            this.map_height = map_height;
            this.map_width = map_width;
            this.sym = sym;
        }
        public Point Create_food()
        {
            int x = random.Next(5, map_width - 5);
            int y = random.Next(5, map_height - 5);
            return new Point(x, y, sym);
        }
        /*public void feedSnake()
        {
            Food_Creator foodCreator = new Food_Creator(Console.LargestWindowWidth, Console.LargestWindowHeight, '$');
            Point food = foodCreator.Create_food();
            food.Draw();
        }*/
    }
}
