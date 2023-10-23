using System;
using System.Collections.Generic;

namespace DemoLibrary
{
	public class CreateTrainingModule : ITrainingModuleBuilder

	{ private string Title;
      private List<string> Topics;
        private string Duration;
        private string DifficultyLevel;


        public ITrainingModuleBuilder BuildTitle(string title)
        {
            this.Title = title;
            return this;
        }

        public ITrainingModuleBuilder BuildTopics(List<string> topics)
        {
            this.Topics = topics;
            return this;
        }

        public ITrainingModuleBuilder BuildDuration(string duration)
        {
            this.Duration = duration;
            return this;
        }

        public ITrainingModuleBuilder BuildDifficultyLevel(string difficultyLevel)
        {
            this.DifficultyLevel = difficultyLevel;
            return this;
        }

        public TrainingModule GetResult()
        {
             TrainingModule module = new TrainingModule(this.Title, this.Topics, this.Duration, this.DifficultyLevel);
            //Console.WriteLine("here");
            //Console.WriteLine(module.GetHashCode());
            return module;
        }
    }
}

