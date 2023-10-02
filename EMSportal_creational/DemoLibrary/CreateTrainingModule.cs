using System;
using System.Collections.Generic;

namespace DemoLibrary
{
	public class CreateTrainingModule : ITrainingModuleBuilder
	{
        private TrainingModule module = new TrainingModule();

        public void BuildTitle(string title)
        {
            module.Title = title;
        }

        public void BuildTopics(List<string> topics)
        {
            module.Topics = topics;
        }

        public void BuildDuration(string duration)
        {
            module.Duration = duration;
        }

        public void BuildDifficultyLevel(string difficultyLevel)
        {
            module.DifficultyLevel = difficultyLevel;
        }

        public TrainingModule GetResult()
        {
            return module;
        }
    }
}

