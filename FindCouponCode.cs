using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramingSeries
{
    internal class FindCouponCode
    {
        public static void CouponCode()
        {
            var chars = "ABCDEFGHIJmnopqrstuvwxyz0123456789";
            var stringChars = new char[6]; // how many charactor of code we want to generate
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];//take char beetween given string 
            }

            Console.WriteLine("generated coupon code is : "+stringChars);
        }
    }
}
