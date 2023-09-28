using System;
namespace DemoLibrary
{
	public class EmployeeFinancesCEO : IEmployeeFinances 
	{
		public double CalculatePay(int rank)
		{
            double baseAmount = 150;

            double Salary = baseAmount * rank;
            return Salary;
        }
    

	}

}
	