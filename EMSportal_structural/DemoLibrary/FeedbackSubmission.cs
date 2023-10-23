using System;
namespace DemoLibrary
{
    class FeedbackSubmission
    {
    public void SubmitForm(Employee employee, string feedback)
    {
        
        Console.WriteLine($"Submitting feedback for {employee.FirstName}: {feedback}");
    }
   
}
}

