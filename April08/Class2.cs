using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{
    internal class Class2
    {

        //I
        //IKM
        //IKMOQ
        //IKMOQSU
        static void Main(string[] args)
        {
            //int c = 0;
            for (char i = 'I'; i <= 'U'; i = (char)(i + 4))
            {

                for (char j = 'I'; j <= i; j = (char)(j + 2))
                {

                    Console.Write((char)(j));
                }

                Console.WriteLine();

            }
        }
    }
}
