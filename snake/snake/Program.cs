﻿using System;
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
            Point point1 = new snake.Point();
            point1.x = 1;
            point1.y = 3;
            point1.symbol = '*';

            point1.Draw();

            Point point2 = new snake.Point();
            point2.x = 5;
            point2.y = 6;
            point2.symbol = '#';

            point2.Draw();


            Console.ReadLine();
        }
    }
}
