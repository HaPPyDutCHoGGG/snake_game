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
      

            /*Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(2,4,'#');
            p2.Draw();*/

            Horizontal_Line line1 = new Horizontal_Line(5,10,10,'#');
            line1.Draww();
            Horizontal_Line line2 = new Horizontal_Line(5, 10, 15, '#');
            line2.Draww();

            Vertical_Line line3 = new Vertical_Line(10, 15, 5, '#');
            line3.Draww();
            Vertical_Line line4 = new Vertical_Line(10, 15, 10, '#');
            line4.Draww();

            /*List<int> numList = new List<int>();
            numList.Add(2);
            numList.Add(1);
            numList.Add(0);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList) {
                Console.WriteLine(numList[i]);
            }*/

            Console.ReadLine(); 

        }     
    }
}
