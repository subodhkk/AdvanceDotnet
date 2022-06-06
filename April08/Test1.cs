using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{
    internal class Test1
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter the number");
            int n=Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                a = n % 10;
                if (a % 2 == 1)
                {
                    n = n / 10;
                    if (n == 0)
                    {
                        //c++;
                        Console.WriteLine("Happy");
                        break;
                    }
                       
                    
                }
                else
                {
                    n = n / 10;
                    Console.WriteLine("Not Happy");
                    break;
                }
                    
            }
        }
    }
}
