using System;
namespace DemoLibrary
{
    public class EmployeeFinancesManager : IEmployeeFinancesProduct
    {
        public double CalculatePay(int rank)
        {
            double baseAmount = 19.75;

            double Salary = baseAmount + (rank * 4);
            return Salary;
        }
    }
}

