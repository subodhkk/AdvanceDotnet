using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections2
{
    internal class Que1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(5);
            Console.WriteLine("Enter 5 Integers= ");
            for (int i = 0; i < al.Capacity; i++)
            {
                al.Add(Console.ReadLine());
            }
            al.Sort();
            foreach (dynamic d in al)
            {
                Console.Write(d + " ");
            }

        }
    }
}
