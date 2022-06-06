using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections1
{
    internal class Remove3
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2,"Two");
            ht.Add(3,"Three");
            ht.Add(4,"Four");
            ht.Add(5,"Five");
            ht.Add(6,"Six");
            ht.Add(7,"Seven");
            ht.Add(8,"Eight");
            ht.Add(9,"Nine");
            ht.Add(10,"Ten");

            DictionaryEntry [] arr=new DictionaryEntry[ht.Count];
            ht.CopyTo(arr,0);

            for(int i=0;i<arr.Length;i++)
            {
                dynamic k = arr[i].Key;
                if(k%3==0)
                {
                    ht.Remove(k);
                }
            }

            foreach (DictionaryEntry k in ht)
                Console.WriteLine(k.Key+ " "+ k.Value);
        }
    }
}
