using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{
    internal class Happy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine());

            int num = n;
            while (n!=0)
            {
                int rem;
                rem = n % 10;
                //n = n / 10;
                int c = 0;

                if (rem % 2 == 1)
                {
                    n = n / 10;
                    num = num * 10 + rem;
                    //Console.WriteLine(num);
                    c++;
                }

                
                //Console.WriteLine("Happy");

                /*else
                    Console.WriteLine("Not Happy");
                 /*if(c==2)
                    Console.WriteLine("Happy num");
                 */
            }
            

        }
    }
}
