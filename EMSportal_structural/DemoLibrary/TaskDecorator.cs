using System;
namespace DemoLibrary
{
    public class TaskDecorator : ITaskGenerator
    {
        private ITaskGenerator taskGenerator;
        private string additionalNote;

        public TaskDecorator(ITaskGenerator taskGenerator, string additionalNote)
        {
            this.taskGenerator = taskGenerator;
            this.additionalNote = additionalNote;
        }

        public string GenerateTask()
        {
            string baseTask = taskGenerator.GenerateTask();
            return $"{baseTask} - {additionalNote}";

        }
    }

}

