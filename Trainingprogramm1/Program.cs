﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            int row = 9;
            int column = 8;
            int stars = 1;
            while (y < row)
            {
                int x = 0;
                while (x < column)
                {
                    Console.Write("  ");
                    x++;
                }
                column--;
                y++;
                int z = 0;
                while (z < stars)
                {
                    Console.Write(" *");
                    z++;
                }
                stars += 2;
                Console.WriteLine();
            }

            int yl = 0;
            int rowl = 8;
            int columnl = 1;
            int starsl = 15;
            while (yl < rowl)
            {
                int xl = 0;
                while (xl < columnl)
                {
                    Console.Write("  ");
                    xl++;
                }
                columnl++;
                yl++;
                int zl = 0;
                while (zl < starsl)
                {
                    Console.Write(" *");
                    zl++;
                }
                starsl -= 2;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}