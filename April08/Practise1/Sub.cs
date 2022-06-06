using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Practise1
{
    class largest_subarray_length
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 0s and 1s array");
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }

            int j;
            int max = 0;
            int zero, ones = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                zero = 0;
                ones = 0;
                for (j = i; j < arr.Length; j++)
                {
                    if (arr[j] == 0)
                        zero++;
                    else
                        ones++;

                    if (zero == ones)
                    {
                        max = max > (j - i + 1) ? max : j - i + 1;
                    }
                }

            }
            Console.WriteLine(max);
        }
    }
}

