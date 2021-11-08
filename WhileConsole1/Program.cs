using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, result = 0;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            int i = 1;
            while(i <= a)
            {
                result += Math.Pow(i, a - i + 1);
                i++;
            }
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
