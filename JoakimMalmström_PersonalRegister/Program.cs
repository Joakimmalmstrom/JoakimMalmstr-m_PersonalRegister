using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoakimMalmström_PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            Console.WriteLine("How many employees would u like to register?");
            int numberEmployees = int.Parse(Console.ReadLine());
            Console.Clear();

            for (int i = 0; i < numberEmployees; i++)
            {
                employee.AddEmployee();
            }

            employee.CompileEmployee();

            Console.Read();
        }
    }
}
