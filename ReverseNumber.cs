using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingSeries
{
    internal class ReverseNumber
    {
        public static void ReverseNum()
        {
            /* Console.WriteLine("Insert the number : ");
             int num=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Original number is : " + num);
             int reminder, Result=0;
             while(num !=0) {
             reminder=num%10;
                 Result = Result * 10 + reminder;
                 num = num/10;

             }
             Console.WriteLine("Reverse number is : " + Result);*/
            //.............reerse String is..............................
            Console.WriteLine("Please insert the string :");
            String Str=Console.ReadLine();
            string  rev;
           
            rev = "";
            Console.WriteLine("Original String is :"+ Str);
            
            int len;   // find string length
            len = Str.Length - 1;
            while (len >= 0)
            {
                rev = rev + Str[len];
                len--;
            }
            Console.WriteLine("Reversed String is : "+ rev);
            Console.ReadLine();
        }
    }
    
}
