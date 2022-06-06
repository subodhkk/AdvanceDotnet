using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections1
{
    internal class StringRev
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(8);
            Console.WriteLine("Enter words");
            for (int i = 0; i < al.Capacity; i++)
            {
                al.Add(Console.ReadLine());
            }
            Console.WriteLine("*********");

            al.Sort();
            al.Reverse();
            foreach (var v in al)
            {
                Console.Write(v + " ");
            }

        }
    }
}
