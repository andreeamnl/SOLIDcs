using System;
namespace DemoLibrary
{
    class FeedbackForm
    {
        public void GenerateForm(Employee employee)
        {
            
            Console.WriteLine($"Generating feedback form for {employee.FirstName} {employee.LastName}");
        }
        
    }
}

