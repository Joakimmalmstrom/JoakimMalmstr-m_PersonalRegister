using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace JoakimMalmström_PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates EmployeeRegister
            EmployeeRegister register = new EmployeeRegister();

            bool isInput = true;
            
            // While isInput is true run this
            while (isInput)
            {
                Console.Clear();

                Console.Write("Employee Name: ");
                string name = Console.ReadLine();
                Console.Write("Employee Salary: ");
                int salary = int.Parse(Console.ReadLine());

                // Adding name & salary to the list
                register.AddEmployee(name, salary);

                // If the user wants to add more employees
                Console.Write("Do you want to add another employee? (y / n): ");
                if (!InputEmployee())
                {
                    // if not, go out of loop
                    isInput = false;
                }

                Console.Clear();
            }

            // Compiling register
            register.CompileRegister();

            Console.Read();
        }

        static bool InputEmployee()
        {
            string input = Console.ReadLine();

            // Matches the user's input of adding another employee to the register
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Error, try again!");
                return InputEmployee();
            }
        }
    }
}
