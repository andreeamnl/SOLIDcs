using System;
namespace DemoLibrary
{
	public class FactoryManagerFinances: IFactoryFinances
	{
		public IEmployeeFinancesProduct CreateFinance()
		{
			return new EmployeeFinancesBase();
		}
	}
}

