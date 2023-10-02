using System;
namespace DemoLibrary
{
	public class FactoryCEOFinance:IFactoryFinances
	{
		public IEmployeeFinancesProduct CreateFinance()
		{
			return new EmployeeFinancesCEO();
		}
	}
}

