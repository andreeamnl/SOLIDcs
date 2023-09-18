using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Ozzy";
            accountingVP.LastName = "Osbourne";
            accountingVP.CalculatePerHourRate(4);

            IManaged emp = new Employee();

            emp.FirstName = "Steve";
            emp.LastName = "Jobs";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ accountingVP.FirstName }'s salary is ${accountingVP.Salary }/hour.");
            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");



            CEO ceo = new CEO();

            ceo.FirstName = "Andreea";
            ceo.LastName = "Manole";
            ceo.CalculatePerHourRate(1000);

            Console.WriteLine($"{ceo.FirstName}'s salary is ${ceo.Salary}/hour.");



            Console.ReadLine();
        }
    }
}
