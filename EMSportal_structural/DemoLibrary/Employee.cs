using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Employee : BaseEmployee, IManaged    
    {
        public IEmployee Manager { get; set; } = null;
        
        public void AssignManager(IEmployee manager)
        {
            
            Manager = manager;  
        }

        public Employee Clone()    //implementation of prtototype pattern 
        {
            return new Employee()
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                Salary = this.Salary
            };

        }


    }
}
