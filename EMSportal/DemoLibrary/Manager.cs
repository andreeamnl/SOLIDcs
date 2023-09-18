using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DemoLibrary.EmployeeFinances;



namespace DemoLibrary
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {

            EmployeeFinances EMMAN = new EmployeeFinancesManager();    //Following SRP means calculatepay method should be handled by a special class
            Salary = EMMAN.CalculatePay(rank);
            //decimal baseAmount = 19.75M;

            //Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
