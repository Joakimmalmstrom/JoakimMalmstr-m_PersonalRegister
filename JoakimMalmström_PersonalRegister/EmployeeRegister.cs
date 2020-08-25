using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace JoakimMalmström_PersonalRegister
{
    class EmployeeRegister
    {
        public EmployeeRegister()
        {
            Name = new List<string>();
            Salary = new List<int>();
        }

        public void AddEmployee(string name, int salary)
        {
            Name.Add(name);
            Salary.Add(salary);
        }

        public void CompileRegister()
        {
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
