using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0F;
            int b = 0;
            double result = 1;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            for(double i = a; i < b; i++)
            {
                result = Math.Pow(a, b);
            }
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
