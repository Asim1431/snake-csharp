using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(1, 3, '*');
            point1.Draw();

            Point point2 = new Point(5, 6, '#');
            point2.Draw();

            HorizontalLine hLine = new HorizontalLine(5, 13, 8, '*');
            hLine.Draw();
            VerticalLine vLine = new VerticalLine(8, 13, 10, '+');
            vLine.Draw();


            Console.ReadLine();
        }
    }
}
