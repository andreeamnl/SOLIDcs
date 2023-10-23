using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Logger logger = Logger.GetInstance();
            logger.SetLogFilePath("Emp.log");

            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Ozzy";
            accountingVP.LastName = "Osbourne";
            IFactoryFinances ManagerEmpFactory = new FactoryBaseFinance();  //Factory pattern
            IEmployeeFinancesProduct ManagerPay = ManagerEmpFactory.CreateFinance();
            accountingVP.Salary = ManagerPay.CalculatePay(6);


            IManaged emp = new Employee();

            emp.FirstName = "Steve";
            emp.LastName = "Jobs";
            emp.AssignManager(accountingVP);
            IFactoryFinances BaseEmpFactory = new FactoryBaseFinance();  //Factory pattern
            IEmployeeFinancesProduct BasePay = BaseEmpFactory.CreateFinance();
            emp.Salary = BasePay.CalculatePay(2);



            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
            Console.WriteLine($"{accountingVP.FirstName}'s salary is ${accountingVP.Salary}/hour.");


            var emp1 = emp.Clone();  //Implementation of prototype pattern
            emp1.FirstName = "Angela";
            Console.WriteLine($"{emp1.FirstName}'s salary is ${emp1.Salary}/hour.");





            BaseEmployee ceo = new CEO();

            ceo.FirstName = "Andreea";
            ceo.LastName = "Manole";
            IFactoryFinances CEOFactory = new FactoryBaseFinance();  //Factory pattern
            IEmployeeFinancesProduct CEOPay = CEOFactory.CreateFinance();
            ceo.Salary = BasePay.CalculatePay(15);



            Console.WriteLine($"{ceo.FirstName}'s salary is ${ceo.Salary}/hour.");




            ITrainingModuleBuilder builder = new CreateTrainingModule();   //Builder Pattern
            // Get the result
            TrainingModule module = builder.BuildTitle("Module 1")
                .BuildTopics(new List<string> { "Compliance and Internal Audit", "Financial Technology Tools" })
                .BuildDuration("2 hours")
                .BuildDifficultyLevel("Intermediate").GetResult(); 
            // Display the training module
            module.Display();


            //Decorator output
            ITaskGenerator basicTaskGenerator = new TaskGenerator();
            ITaskGenerator taskWithNote = new TaskDecorator(basicTaskGenerator, " Contact HR for monthly feedback. ");

            string basicTask = basicTaskGenerator.GenerateTask();
            string taskWithNoteResult = taskWithNote.GenerateTask();

            Console.WriteLine("Basic Task: " + basicTask);
            Console.WriteLine("Task with Note: " + taskWithNoteResult);
            Console.WriteLine();

            //Facade code
            MonthlyFeedbackFacade facade = new MonthlyFeedbackFacade(emp1);
            string feedback = "Did an excellent job this month.";
            facade.GenerateAndSubmitFeedbackForm(feedback);

            logger.Log();
            Console.ReadLine();
        }
    }
}
