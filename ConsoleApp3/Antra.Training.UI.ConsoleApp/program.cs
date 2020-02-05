using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.UI.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu m = new Menu();
            m.Print();
            int choice = Convert.ToInt32(Console.ReadLine());
            Employee employee = new EmployeeFactory().GetObject(choice);
            if (employee != null)
            {
                employee.AddEmployee();
                employee.PrintEmployee();
            }
            //method hiding vs method overriding
            // you can create parent class object with the child class constructor
            // during method hiding call will always go to parent class method

            Console.Read();
        }
    }
}
