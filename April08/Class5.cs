using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08
{
    class Depatment 
    {
        //int dep_id;
        //string dep_name;
        //string dep_loc;

        public int Dep_id { get; set ; }
        public string Dep_name { get; set ; }
        public string Dep_loc { get ; set ; }
        
    }

    class DeptRun
    {
        static void Main(string[] args)
        {
            Depatment d = new Depatment();
            d.Dep_id = 101;
            d.Dep_name = "Deveplopment";
            d.Dep_loc = "Pune";


            Console.WriteLine("Department= " +d.Dep_id);
            Console.WriteLine("Department Name= " +d.Dep_name);
            Console.WriteLine("Locatoin= " +d.Dep_loc);
        }
    }


    public class Emp3
    {
        static int id;
        private int count;
        public string name { get; set; }
        public int salary { get; set; }

        public override string ToString()
        {
            return $"ID= {id} Name= {name} Salary= {salary}";
        }

        public Emp3(string name, int salary)
        {
            count++;
            id=count;
            this.name = name;
            this.salary = salary;
        }

        public void Showcount()
        {
            Console.WriteLine(count);
        }

    }
    class EmpRun
    {
        static void Main(string[] args)
        {
            Emp3 e1 = new Emp3("A", 1000);
            //Console.WriteLine(e3);
            Emp3 e2 = new Emp3("B", 2000);
            //Console.WriteLine(e4);
            Emp3 e3 = new Emp3("C", 4000);

            
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine(e3);

            Emp3 [] ob=new Emp3[5];
            ob[1]= e1;
            ob[2]= e2;
            ob[3]= e3;

            foreach (Emp3 d in ob)
            {
                Console.WriteLine(d);
            }
        }
        
    }

    public class Product
    {
        public Product(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public override string ToString()
        {
            return $"id={id}, Name=  {name}, Price= {price}";
        }
    }



    class ProductRun
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(1, "mobile", 5000);
            Product p2 = new Product(2, "soap", 40);
            Product p3 = new Product(3, "car", 50000);
            Product p4 = new Product(4, "vehicle", 30000);
            Product[] p = new Product[5];

            p[1] = p1;
            p[2] = p2;
            p[3] = p3;
            p[4] = p4;

            foreach(Product pp in p)
            {
                Console.WriteLine(pp);
            }
        }
       


    }

    class Array2d
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 3]
            {
                {1,2,4 },
                {3,4,3 },
                {5,8,6 },
                {6,9,7 }
            };

            //for(int i= 0; i < 4; i++)
            //{
            //    for(int j=0; j < 3; j++)
            //    {
            //        Console.WriteLine("Row="+ i + " " +"Column="+ j);
            //        arr[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j=0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
        
    }


    class JaggedA
    {
        static void Main(string[] args)
        {
            int[][] ja=new int[3][];

            ja[0]= new int[3];
            ja[1]= new int[2];
            ja[2]= new int[4];

            ja[0][0] = 2;
            ja[0][1] = 3;
            ja[0][2] = 4;

            ja[1][0] = 5;
            ja[1][1] = 6;

            ja[2][0] = 7;
            ja[2][1] = 8;
            ja[2][2] = 9;
            ja[2][3] = 10;


            for(int i=0;i<ja.Length;i++)
            {
                for(int j=0;j<ja[i].Length;j++)
                {
                    Console.Write(ja[i][j]+ " ");

                }
                Console.WriteLine();
            }
        }
    }

    class Dict
    {
        static void Main(string[] args)
        {
            IDictionary<int,string> dt=new Dictionary<int,string>();

            dt.Add(91, "India");
            dt.Add(1,"America");
            dt.Add(63, "USA");

            foreach (KeyValuePair<int, string> kvp in dt)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
    }

    public delegate void Mydel(string nm);

    //class Bank
    //{
    //    public event Mydel balIsZero;
    //    public event Mydel insufficientBal;
    //    int bal;
    //    public Bank()
    //    {
    //        bal = 0;
    //    }
    //    public void credit(int n)
    //    {
    //        bal = bal + n;
    //    }
    //    public void debit(int n)
    //    {
    //        if (bal < n)
    //        {
    //            InsufficientBal();
    //        }
    //        if (bal >= n)
    //        {
    //            bal = bal - n;
    //            if (bal == 0)
    //            {
    //                balIsZero();
    //            }
    //        }
    //    }
    //}
    //class Bank1
    //{
    //    static void InsufficientBalance()
    //    {
    //        Console.WriteLine("Insufficient Balance");
    //    }
    //    static void ZeroBalnce()
    //    {
    //        Console.WriteLine("Balance is zero");
    //    }
    //    static void Main(string[] args)
    //    {
    //        Bank b = new Bank();
    //        b.balIsZero += new Mydel(ZeroBalnce);
    //        b.insufficientBal += new Mydel(InsufficientBalance);
    //        // b.credit(100);
    //        b.debit(100);
    //    }
    //}


}
