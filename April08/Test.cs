using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{
    internal class Test
    {
        public static int Happy(int num)
        {
            int rem = 0, sum = 0;             
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem);
                num = num / 10;
            }
            return sum;
        }

        public static void Main()
        {
            Console.WriteLine("Enter number");
            int num=Convert.ToInt32(Console.ReadLine());
            int result = num;

            while (result != 1 && result != 4)
            {
                result = Happy(result);
            }

            //Happy number always ends with 1  
            if (result == 1)
                Console.WriteLine(num + " is a happy number");
            //Unhappy number ends in a cycle of repeating numbers which contains 4  
            else if (result == 4)
                Console.WriteLine(num + " is not a happy number");
        }
    }
}
