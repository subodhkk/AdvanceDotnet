using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace April08.Collections2
{
    internal class Que2
    {
        class Employee : IComparable
        {
            string name, designation;
            int salary;

            public Employee(string name, string designation, int salary)
            {
                this.Name = name;
                this.Designation = designation;
                this.Salary = salary;
            }

            public string Name { get => name; set => name = value; }
            public string Designation { get => designation; set => designation = value; }
            public int Salary { get => salary; set => salary = value; }

            public int CompareTo(object obj)
            {
                Employee e = (Employee)obj;

                return e.salary.CompareTo(salary);
            }

            public override bool Equals(object obj)
            {
                return obj is Employee employee &&
                       name == employee.name &&
                       designation == employee.designation &&
                       salary == employee.salary;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(name, designation, salary);
            }

            public override string ToString()
            {
                return "name:" + name + " " + "Designation:" + designation + " " + "Salary:" + salary;
            }
        }

    }
}
