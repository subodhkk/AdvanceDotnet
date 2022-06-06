using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{
    internal class Class1
    {
        //I
        //IKM
        //IKMOQ
        //IKMOQSU


        static void Main(string[] args)
        {
            int c = 1;
            for (char i = 'I'; i <= 'V'; i = (char)(i + 4))
            {
                while (c % 2 == 0)
                    break;
               /*if (i == 'J' || i == 'L' || i == 'N' || i == 'P')
                    break;*/
                
                for (char j = 'I'; j <= i; j++)
                {
                    if (j == 'J' || j == 'L' || j == 'N' || j == 'P')
                      break;
                    Console.Write(j);
                    j++;
                    
                }
                c++;
                Console.WriteLine();
            }
        }
        

    }
}
