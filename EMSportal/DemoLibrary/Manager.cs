using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DemoLibrary
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int rank, IEmployeeFinances EMMAN)
        {

            ///EmployeeFinances EMMAN = new EmployeeFinancesManager();    //Following SRP means calculatepay method should be handled by a special class
            Salary = EMMAN.CalculatePay(rank);
        }

        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
