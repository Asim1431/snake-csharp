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
            Point point1 = new Point(1, 3, '*');
            point1.Draw();

            Point point2 = new Point(5, 6, '#');
            point2.Draw();


            Console.ReadLine();
        }
    }
}
