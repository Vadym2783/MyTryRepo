using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 0;
           a++;
           while (a>0)
           {
         Console.WriteLine("write the symbol");
         string symbol = Console.ReadLine();
         Console.WriteLine("write quantity of row");
         int row = int.Parse(Console.ReadLine());
         int column = (row-1)/2;
            int y = 0;
            int stars = 1;
            if (row%2==1)
            {
            while (y < (row-1)/2+1)
            {
                    int x = 0;
                    while (x < column)
                    {
                        Console.Write("  ");
                        x++;
                    }
                    column--;
                    y++;
                    int z =0;
                    while (z < stars)
                    {
                        Console.Write(" ");
                        Console.Write(symbol);
                        z++;
                    }
                    stars += 2;
                    Console.WriteLine();
            }
            int yl = 0;
            int rowl = (row-1)/2;
            int columnl = 1;
            int starsl = row-2;
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
                int zl =0;
                while (zl < starsl)
                {
                    Console.Write(" ");
                    Console.Write(symbol);
                    zl++;
                }
                starsl -= 2;
                Console.WriteLine();
            }
            }
            else if (row%2==0)
            {
            int columnh = row/2;
            int yh = 0;
            int starsh = 1;
            	while (yh < row/2)
            {
                    int xh = 0;
                    while (xh < columnh)
                    {
                        Console.Write(" ");
                        xh++;
                    }
                    columnh--;
                    yh++;
                    int zh =0;
                    while (zh < starsh)
                    {
                        Console.Write(symbol);
                        zh++;
                    }
                    starsh += 2;
                    Console.WriteLine();
            }
            int ylh = 0;
            int rowlh = row/2;
            int columnlh = 1;
            int starslh = row-1;
            while (ylh < rowlh)
            {
                int xlh = 0;
                while (xlh < columnlh)
                {
                    Console.Write(" ");
                    xlh++;
                }
                columnlh++;
                ylh++;
                int zlh =0;
                while (zlh < starslh)
                {
                    Console.Write(symbol);
                    zlh++;
                }
                starslh -= 2;
                Console.WriteLine();
            }
            }
           }
            Console.ReadLine();
        }
    }
}
