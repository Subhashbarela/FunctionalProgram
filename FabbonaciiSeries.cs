using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingSeries
{
    internal class FabbonaciiSeries
    {
        public static void fabbo()
        {
            Console.WriteLine("Enter the range to find fibbonacci number : ");
            int len = Convert.ToInt32(Console.ReadLine());
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            Console.WriteLine("");
        }
    }
}
