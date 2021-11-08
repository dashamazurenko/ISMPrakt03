using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, Fact = 1, result = 1;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            if (a == 0)
                Console.Write("Error");
            for(double i = 1; i <= a; i++)
            {
                result += Fact *= i;
            }
            Console.Write(result);
            Console.ReadKey();

        }
    }
}
