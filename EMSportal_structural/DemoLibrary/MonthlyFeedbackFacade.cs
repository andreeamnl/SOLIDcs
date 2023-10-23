using System;
namespace DemoLibrary
{
    public class MonthlyFeedbackFacade
    {
        private Employee employee { get; set; }
        private FeedbackForm form;
        private FeedbackSubmission submission;

        public MonthlyFeedbackFacade(Employee employee)
        {
            this.employee = employee;
            form = new FeedbackForm();
            submission = new FeedbackSubmission();
        }

        public void GenerateAndSubmitFeedbackForm(string feedback)
        {
            form.GenerateForm(employee);
            submission.SubmitForm(employee, feedback);
            Console.WriteLine();

        }
    }
}

