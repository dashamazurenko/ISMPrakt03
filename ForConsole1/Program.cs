using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, result = 1;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            if(a > b)
            {
                Console.Write("Error");
            }
            for(int i = a; i <= b; i++)
            {
                result *= i;
            }
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
