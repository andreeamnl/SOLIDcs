using System;
namespace DemoLibrary
{
    public class EmployeeFinancesBase : IEmployeeFinancesProduct
    {
        public double CalculatePay(int rank)
        {
            double baseAmount = 12.50;

            double Salary = baseAmount + (rank * 2);
            return Salary;
        }
    }

}
