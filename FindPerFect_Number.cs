using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingSeries
{
    internal class FindPerFect_Number
    {
        public static void PerfectNumber()
        {
            int n, i, sum;
            int len;

         
            Console.Write("Input the ending range of number : ");
            len = Convert.ToInt32(Console.ReadLine());
            
            for (n = 1; n <= len; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
            Console.ReadKey();  


            //..................... check given number is perfect number or not..................
            /* int number, sum = 0, n;
             Console.Write("enter the Number");
             number = int.Parse(Console.ReadLine());
             n = number;
             for (int i = 1; i < number; i++)
             {
                 if (number % i == 0)
                 {
                     sum = sum + i;
                 }
             }
             if (sum == n)
             {
                 Console.WriteLine("\n {n} number is a perfect number",n);
                 Console.ReadLine();
             }
             else
             {
                 Console.WriteLine("\n  number is not a perfect number");
                 Console.ReadLine();
             }*/
        }

    }
    
}
