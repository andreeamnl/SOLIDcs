using System;
namespace DemoLibrary
{
    public class TaskGenerator : ITaskGenerator
    {
        public string GenerateTask()
        {
            return "Check payslips for mistakes;";
        }
    }

}

