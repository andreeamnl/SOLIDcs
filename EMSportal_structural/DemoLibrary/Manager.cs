using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DemoLibrary
{
    public class Manager : Employee, IManager
    {
        public override void Greet()
        {

            ///EmployeeFinances EMMAN = new EmployeeFinancesManager();    //Following SRP means calculatepay method should be handled by a special class
            Console.WriteLine("Welcome new Manager!");
        }

        public void GeneratePerformanceReview()
        {
            // Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }
    }
}
