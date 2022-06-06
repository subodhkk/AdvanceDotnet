using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections2
{
    internal class Que8 
    {
           
        static void Main(string[] args)
        {
            SortedList<object, string> st = new SortedList<object, string>();
            st.Add(new Employee("suraj", "Manager", 50000), "Finance");
            st.Add(new Employee("amit", "supervisior", 12000), "production");
            st.Add(new Employee("raju", "Accountant", 35000), "Accounts");

            foreach (KeyValuePair<object, string> kv in st)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
        }
    }
}
