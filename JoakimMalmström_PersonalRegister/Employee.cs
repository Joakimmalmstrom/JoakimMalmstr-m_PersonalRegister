using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoakimMalmström_PersonalRegister
{
    class Employee
    {
        public Employee()
        {
            Name = new List<string>();
            Salary = new List<int>();
        }

        public void AddEmployee()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Salary: ");
            int salary = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Name.Add(name);
            Salary.Add(salary);
        }

        public void CompileEmployee()
        {
            Console.Clear();

            for (int i = 0; i < Name.Count; i++)
            {
                Console.WriteLine("Employee " + (1 + i));
                Console.WriteLine("Name: " + Name[i]);
                Console.WriteLine("Salary: " + Salary[i]);
                Console.WriteLine("");
            }
        }

        List<string> Name;
        List<int> Salary;
    }
}
