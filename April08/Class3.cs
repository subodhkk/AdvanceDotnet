﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //int sum = 0;

            for (int i = 0; i < arr.Length-1; i=i+2)
            {
                int sum = 0;
                    sum = arr[i] + arr[i+1];
                        

                Console.WriteLine(sum);
            }

        }
    }
}
