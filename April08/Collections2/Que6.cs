using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections2
{
    internal class Que6
    {
        static void Main(string[] args)
        {
            Dictionary<string, float> d = new Dictionary<string,float>();
            d.Add("Suraj3",4.3f);
            d.Add("Suraj2",1.7f);
            d.Add("Suraj8",6.4f);
            d.Add("Suraj6",9.3f);
            d.Add("Suraj4",5.6f);
            d.Add("Suraj1",6.5f);


            foreach (KeyValuePair<string, float> de in d)
            {
                Console.WriteLine(de.Key + " " + de.Value);
            }
        }
    }
}
