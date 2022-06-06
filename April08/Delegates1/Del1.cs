using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Delegates1
{
    internal class Del1
    {
        public delegate int d1(int a, int b);
        public static int multi(int a,int b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            d1 obj = multi;
            Console.WriteLine(obj(3,6));
        }
    }



    // using Func Delegate

    class Del2
    {
        public static int square(int a)
        {
            return a * a;
        }
        static void Main(string[] args)
        {
            Func<int,int> func = square;
            Console.WriteLine(func(12));
        }
    }



    // Using Action Delegate

    class Del3
    {
        public static void fun(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            Action<int,int> t= fun;
            t(20, 6);
        }
    }

    //Using Predicate Delegates

    class Del4
    {
        public static bool even( int a)
        {
            if(a%2==0)
            {
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {
            Predicate<int> val = even;
            Console.WriteLine("Enter the value=");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entered value is even= "+ val(a));
            
        }
    }
}
