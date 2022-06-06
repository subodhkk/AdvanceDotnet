using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections1
{
    internal class Encryption
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String:");
            String? s = Console.ReadLine();
            string[] str = s.Split();
            int[] arr = new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                int total = 0;

                char[] ch = str[i].ToLower().ToCharArray();
                for (int j = 0; j < str[i].Length; j++)
                {
                    if (ch[j] >= 97 && ch[j] <= 122)
                    {
                        total = total + (ch[j] - 96);
                    }

                }
               // Console.WriteLine(total);

                arr[i] = total;
            }


            for (int i = 0; i < arr.Length; i++)
            {


                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        string temp = str[i];
                        str[i] = str[j];
                        str[j] = temp;

                        int temp1 = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp1;

                    }
                }
                Console.WriteLine(str[i] + "-"+arr[i]);
                //Console.Write(str[i] + " ");
            }



        }
    }
}
