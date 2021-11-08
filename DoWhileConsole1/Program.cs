using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int summa = 0;
            do
            {
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());
                summa += n;
            } while (n != 0);
            Console.Write($"Summa = {summa}");
            Console.ReadKey();
        }
    }
}
