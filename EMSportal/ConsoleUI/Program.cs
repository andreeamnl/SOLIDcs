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
            IEmployeeFinances EMMAN = new EmployeeFinancesManager();
            accountingVP.CalculatePerHourRate(4, EMMAN);

            IManaged emp = new Employee();

            emp.FirstName = "Steve";
            emp.LastName = "Jobs";
            emp.AssignManager(accountingVP);
            IEmployeeFinances EMMP = new EmployeeFinancesBase();
            emp.CalculatePerHourRate(2, EMMP);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
            Console.WriteLine($"{ accountingVP.FirstName }'s salary is ${accountingVP.Salary }/hour.");



            BaseEmployee ceo = new CEO();

            ceo.FirstName = "Andreea";
            ceo.LastName = "Manole";

            IEmployeeFinances EMCEO = new EmployeeFinancesCEO();
            ceo.CalculatePerHourRate(1000, EMCEO);

            Console.WriteLine($"{ceo.FirstName}'s salary is ${ceo.Salary}/hour.");



            Console.ReadLine();
        }
    }
}
