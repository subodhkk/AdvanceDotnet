using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections1
{
    internal class ArrList
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");

            for (int i = 0; i < al.Count; i++)
            {

                for (int j = i + 1; j < al.Count; j++)
                {

                    if (al[i] == al[j])
                    {
                        al.RemoveAt(j);
                        j--;
                    }
                }
            }
            foreach (var v in al)
            {
                Console.WriteLine(v);
            }

        }
    }
}
