using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections2
{
    internal class Que7
    {
        static void Main(string[] args)
        {

            Stack<string> st = new Stack<string>();
            st.Push("zindagi na milegy dobara");
            st.Push("vivah");
            st.Push("hum aapke hain kon");
            st.Push("singham");
            st.Push("wanted");

            foreach (var v in st)
            {
                Console.WriteLine(v);

            }
            st.Pop();
            st.Pop();
            Console.WriteLine();
            Console.WriteLine("After Pop Operation:");
            foreach (var v in st)
            {
                Console.WriteLine(v);

            }
        }
    }
}
