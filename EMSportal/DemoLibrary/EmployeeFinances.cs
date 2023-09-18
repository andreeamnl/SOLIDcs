using System;
namespace DemoLibrary
{
    public class EmployeeFinances       //EmployeeFinnaces class handles only financial operations, teherfore respecting SRP
    {
        public virtual double CalculatePay(int rank)
        {
            return 0;
        }

        public class EmployeeFinancesCEO : EmployeeFinances   //inheritance makes our class open for extension and closed for modification, respecting OCP
        {
            public override double CalculatePay(int rank)
            {
                double baseAmount = 150;

                double Salary = baseAmount * rank;
                return Salary;
            }
        }

       public class EmployeeFinancesManager : EmployeeFinances
       {
             public override double CalculatePay(int rank)
             {
                 double baseAmount = 19.75;

                 double Salary = baseAmount + (rank * 4);
                 return Salary;
             }
        }

        public class EmployeeFinancesBase : EmployeeFinances
        {
             public override double CalculatePay(int rank)
             {

                double baseAmount = 12.50;

                double Salary = baseAmount + (rank * 2);
                 return Salary;
              }
        }


        
    }
}

