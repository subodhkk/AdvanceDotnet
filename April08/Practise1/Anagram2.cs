using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Practise1
{
    public class Program
    {
        public string IsAnagram(string input1, string input2)
        {
            string s = "";
            if (input1.Length == input2.Length)
            {
                char[] ch1 = input1.ToCharArray();
                char[] ch2 = input2.ToCharArray();
                int c1 = 0, c2 = 0, count = 0;
                for (int i = 0; i < input1.Length; i++)
                {

                    for (int j = 0; j < input1.Length; j++)
                    {
                        if (ch1[i] == ch1[j])
                        {
                            c1++;
                        }
                        if (ch1[i] == ch2[j])
                        {
                            c2++;
                        }
                    }
                    if (c1 != c2)
                    {
                        count++;
                        s = "Not Anagram";
                        break;
                    }

                }
                if (count == 0)
                {
                    Console.WriteLine();
                    s = "Anagram";
                }
                else
                    s = "Not Anagram";

            }
            else
                s = "Not Anagram";
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st String");
            string? str1 = Console.ReadLine();
            Console.WriteLine("Enter the 2nd String");
            string? str2 = Console.ReadLine();
            Program a = new Program();
            Console.WriteLine(a.IsAnagram(str1, str2));



        }
    }
}
