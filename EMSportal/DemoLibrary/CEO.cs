using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank, IEmployeeFinances EMCEO)
        {
            Salary = EMCEO.CalculatePay(rank);                //Following SRP means calculatepay method should be handled by a special class
        }

        public void GeneratePerformanceReview()    //only ceo can generate PR, no other type of employee, 
        {
            Console.WriteLine("I'm reviewing a direct report's performance.");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're Fired!");
        }
    }
}
