using System;
namespace DemoLibrary
{
	public class FactoryBaseFinance: IFactoryFinances

	{
		public IEmployeeFinancesProduct CreateFinance()
		{
			return new EmployeeFinancesBase();
		} 
	}
}

