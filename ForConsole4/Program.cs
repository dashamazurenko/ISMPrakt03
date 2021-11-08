using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0.0F, b = 0.0F;
            double result = 0;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            for (double i = a; i <= b; i++) 
            {
                result += Math.Pow(i, 2);
            }
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
