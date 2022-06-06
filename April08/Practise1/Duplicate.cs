using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Practise1
{
    internal class Duplicate
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array of string");
            string? s=Console.ReadLine();
            s=s.ToLower();
            string []arr=s.Split(" ");
            
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length-1; j++)
                {
                    if(arr[i]==arr[j])
                    {
                        Console.WriteLine($"Word {arr[i]} at position {i} is duplicate with {j} position ");
                        //arr[j] = " ";
                    }

                }
            }

        }
    }
}
