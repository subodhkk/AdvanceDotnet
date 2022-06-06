using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections2
{
    internal class Que3
    {
        static void Main(string[] args)
        {
            Queue<String> q = new Queue<string>();
            q.Enqueue("red");
            q.Enqueue("blue");
            q.Enqueue("green");
            q.Enqueue("blue");
            q.Enqueue("white");
            q.Enqueue("silver");
            q.Enqueue("blue");

            Console.Write("Value at PEEK is = ");
            Console.WriteLine(q.Peek());


            foreach (dynamic d in q)
            {
                Console.Write(d + " ");
            }


        }
    }
}
