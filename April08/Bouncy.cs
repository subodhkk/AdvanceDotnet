using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{
     internal class Bouncy
     {


         static void Main(string[] args)
         {
             Console.WriteLine("Enter the number");
             int num=Convert.ToInt32(Console.ReadLine());
            int a = num;

                 int rem;
            while (num != 0)
            {

                rem = num % 10;
                num = num / 10;
                int rem1 = num % 10;
                num = num / 10;

                if (rem > rem1 && rem1 > num)
                {
                    Console.WriteLine("Increasing");
                    break;
                }
                else if (num > rem1 && rem1 > rem)
                {
                    Console.WriteLine("Decreasing");
                    break;
                }                   
                else
                {
                    Console.WriteLine("Bouncy");
                    break;
                }
                    
            }
         }
     }
 }

    


