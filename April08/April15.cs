using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{
    internal class April15
    {
        static void Main(string[] args)
        {
            int n,rev=0,rem;
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());

            while (n!=0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;

            }
            Console.WriteLine("Reverse number is  " +rev);

        }
    }

    abstract class Student
    {
        internal int per;

        public void dis()
        {
            Console.WriteLine(" in abstract");
        }
    }
    class Display: Student
    {
            static void Main(string[] args)
            {
                Display d1=new Display();
                d1.dis();
            }
    }     //Student s1=new Student();
    


}
