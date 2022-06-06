using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections1
{
    internal class FreqCity
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");

            Hashtable h=new Hashtable();

            foreach(dynamic k in al)
            {
                if(h.ContainsKey(k))
                {
                    int oldval=h[k];
                    h[k]=oldval+1;
                }
                else
                    h.Add(k,1);
            }

            foreach(DictionaryEntry e in h)
                Console.WriteLine(e.Key+ " " +e.Value);
        }
    }
}
