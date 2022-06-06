using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections2
{
    internal class Que5
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(5, "suraj");
            sl.Add(2, "smita");
            sl.Add(6, "jeevan");
            sl.Add(4, "neha");
            foreach (var v in sl)
            {
                Console.WriteLine(v.Key + " " + v.Value);
            }


        }
    }
}
