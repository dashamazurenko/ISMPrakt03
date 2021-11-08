using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double p;
            Console.Write("p = ");
            p = double.Parse(Console.ReadLine());
            int k = 1;
            double d = 10, summa = 10;
            while(summa <= 200)
            {
                ++k;
                d += d * p / 100;
                summa += d;
            }
            Console.WriteLine($"summa =\t{summa}");
            Console.WriteLine($"kilkist' dniv =\t{k}");
            Console.ReadKey();
        }
    }
}
