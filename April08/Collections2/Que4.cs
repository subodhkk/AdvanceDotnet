using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections2
{
    internal class Que4
    {
        static void Main(string[] args)
        {
            HashSet<object> hs = new HashSet<object>();
            hs.Add(new Employee("suraj", "sr.developer", 25000));
            hs.Add(new Employee("amit", "project lead", 50000));
            hs.Add(new Employee("ritik", "QA", 20000));
            hs.Add(new Employee("suraj", "jr.developer", 15000));
            hs.Add(new Employee("suraj", "sr.developer", 25000));

            foreach (dynamic d in hs)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();

            for (int i = 0; i < hs.Count; i++)
            {
                Console.WriteLine();
            }


        }
    }
}
