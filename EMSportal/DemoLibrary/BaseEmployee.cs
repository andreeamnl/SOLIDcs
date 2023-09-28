using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public abstract class BaseEmployee : IEmployee    //we never want to instantiate this class, we base high-level modules on abstractions, DIP 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public virtual void CalculatePerHourRate(int rank, IEmployeeFinances EMBASE)
        {

            //EmployeeFinances EMBASE = new EmployeeFinancesBase();   //Following SRP means calculatepay method should be handled by a special class
            Salary = EMBASE.CalculatePay(rank);
        }
    }
}
