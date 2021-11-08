using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, k = 0;
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            while (Math.Pow(3, k) < a)
            {
                k++;
            }
            Console.Write(k);
            Console.ReadKey();
        }
    }
}
