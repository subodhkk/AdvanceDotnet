using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Practise1
{
    internal class Coprime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input 1st Number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input 2nd Number");
            int num2=Convert.ToInt32(Console.ReadLine());
            int hcf=0;

            for(int i=1;i<num1;i++)
            {
                if(num1%i==0 && num2%i==0)
                {
                    hcf++;
                }
            }
            if (hcf == 1)
                Console.WriteLine("Co Prime Numbers");
            else
                Console.WriteLine("Not Co prime Numbers");

        }
    }
}
