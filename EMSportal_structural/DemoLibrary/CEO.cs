using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CEO : BaseEmployee, IManager
    {
        public override void Greet()
        {
            Console.WriteLine("Welcome new CEO");
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
