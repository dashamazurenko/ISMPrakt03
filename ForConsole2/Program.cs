using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            float result = 0.0F;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                result += 1.0F / i;
            }
            Console.Write(result);
            Console.ReadKey();
        }
    }
}
