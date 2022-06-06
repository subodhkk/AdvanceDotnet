using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Practise1
{
    internal class Practise2
    {

        public bool Anagram(char[] a1, char[] a2)
        {
            int n1 = a1.Length;
            int n2 = a2.Length;

            if (n1 == n2)
            {
                int c1 = 0, c2 = 0, count = 0;
                for (int i = 0; i < n1; i++)
                {

                    for (int j = 0; j < n1; j++)
                    {
                        if (a1[i] == a1[j])
                        {
                            c1++;
                        }
                        if (a1[i] == a2[j])
                        {
                            c2++;
                        }
                    }
                    if (c1 != c2)
                    {
                        count++;
                        Console.WriteLine("No");
                        break;
                    }

                }
                if (count == 0)
                {
                    Console.WriteLine("yes");
                }
                else
                    Console.WriteLine("no");
                return true;
            }
            return false;

        }           

           
        
    }

    class RunAnagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st String");
            string? a1=Console.ReadLine();
            char [] arr1 = a1.ToLower().ToCharArray();
            Console.WriteLine("Enter the 2nd String");
            string? a2=Console.ReadLine();
            char [] arr2 = a2.ToLower().ToCharArray(); ;
            
            Practise2 p1=new Practise2();
            p1.Anagram(arr1,arr2);
            
        }
    }
}
