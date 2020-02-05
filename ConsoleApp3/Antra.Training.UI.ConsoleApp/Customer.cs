using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.Training.UI.ConsoleApp
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public virtual void AddCustomer()
        {
            Console.Write("Enter Id -> ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name -> ");
            Name = Console.ReadLine();

            Console.Write("Enter Department -> ");
            Address = Console.ReadLine();

            Console.Write("Enter Mobile -> ");
            Mobile = Console.ReadLine();
        }

        public virtual void PrintCustomer()
        {
            Console.WriteLine("Id = " + Id);
            Console.WriteLine("Name = " + Name);
            Console.WriteLine("Department = " + Address);
            Console.WriteLine("Mobile = " + Mobile);
        }
    }
    class CustomerCredit
    {
        public Customer GetObject(int credit)
        {
            switch (credit)
            {
                case (int)Options.FullTimeEmployee:
                    return new FullTimeEmployee();

                case (int)Options.PartTimeEmployee:
                    return new PartTimeEmployee();
                case (int)Options.RemotelyWorkingEmployee:
                    return new RemotelyWorkingEmployee();
                default:
                    Console.WriteLine("Invalid Option");
                    return null;
            }
        }
    }
}
