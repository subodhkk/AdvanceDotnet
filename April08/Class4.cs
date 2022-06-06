using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{


    class Student1 : IComparable
    {
        string sname;
        int per;
        string addr;

        public Student1(string sname, int per, string addr)
        {
            this.Sname = sname;
            this.Per = per;
            this.Addr = addr;
        }

        public string Sname { get => sname; set => sname = value; }
        public int Per { get => per; set => per = value; }
        public string Addr { get => addr; set => addr = value; }

        public override string ToString()
        {
            return $"Name={sname}   per={per}   address={addr}";

        }
        public int CompareTo(Object o)
        {
            Student1 s2 = (Student1)o;
            return per.CompareTo(s2.per);

        }
    }
    class Aa
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            s.Add(new Student1("suraj", 68, "pune"), "java");
            s.Add(new Student1("vishal", 78, "Nashik"), "java");
            s.Add(new Student1("Ajit", 95, "Mumbai"), "Html");
            s.Add(new Student1("Rushi", 50, "pune"), "C++");
            foreach (DictionaryEntry d in s)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
        }
    }
}
