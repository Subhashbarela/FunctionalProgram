using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingSeries
{
    internal class FindPrimeFactore
    {
        public static void PrimeFactor()
        {
            /*  int a, b;
              Console.WriteLine("Please enter your integer: ");
              a = int.Parse(Console.ReadLine());
              for (b = 1; b <= a; b++)
              {
                  if (a % b == 0)
                  {
                      Console.Write(b+" ");
                  }
              }
              Console.ReadLine();*/

            //.......find prime number...............

            Console.WriteLine("Please enter your Range : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    //Console.Write(i + " ");
                    count++;
                }
            }
            if (count == 0) {
                Console.WriteLine(num+" is prime number :");
                }
            else
            {
                Console.WriteLine(num + " not a prime number :");
            }
            Console.ReadLine();

        }
    }
}

