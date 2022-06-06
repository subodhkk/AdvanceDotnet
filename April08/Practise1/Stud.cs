using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Practise1
{
    class Stud1 : IComparable
    {
        string sname;
        int per;
        string city;

        public Stud1(string sname, int per, string city)
        {
            this.Sname = sname;
            this.Per = per;
            this.City = city;
        }

        public string Sname { get => sname; set => sname = value; }
        public int Per { get => per; set => per = value; }
        public string City { get => city; set => city = value; }

        public int CompareTo(object o)
        {
            Stud1 s1=(Stud1)o;
           /* if (this.Per < s1.Per)
                return -1;
            else if (this.Per > s1.Per)
                return +1;
            else
                return 0;*/

            return per.CompareTo(s1.Per);
        }

        public override string ToString()
        {
            return $"Name:{ sname} City: {city} Percent: {per}";
        }
    }
    internal class Stud
    {
        static void Main(string[] args)
        {
            SortedList ss=new SortedList();
            ss.Add(new Stud1("Balaji", 90, "Pune"), "Java");
            ss.Add(new Stud1("Sumit", 93, "Mumbai"), "React");
            ss.Add(new Stud1("Amol", 92, "Kolhapur"), "c#");
            ss.Add(new Stud1("Sam", 95, "Pune"), "Angular");

            foreach(DictionaryEntry d in ss)
                Console.WriteLine(d.Key+" "+d.Value);
        }
    }


    class Stud2
    {
        static void Main(string[] args)
        {

        }
    }



    class LL
    {
        static void Main(string[] args)
        {
            LinkedList<int> l=new LinkedList<int>();
            l.AddFirst(32);
            l.AddFirst(54);
            l.AddLast(34);

        }
    }
}
