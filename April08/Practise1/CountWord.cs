using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Practise1
{
    internal class CountWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string? s=Console.ReadLine();
           char[] s1=s.ToLower().ToCharArray();
            //ch[] s1=s.ToCharArray();

            Console.WriteLine(s1.Length);
        }
    }
}
