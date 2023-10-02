using System;
using System.Collections.Generic;

namespace DemoLibrary
{
	public interface ITrainingModuleBuilder
	{
        void BuildTitle(string title);
        void BuildTopics(List<string> topics);
        void BuildDuration(string duration);
        void BuildDifficultyLevel(string difficultyLevel);
        TrainingModule GetResult();
    }
}

