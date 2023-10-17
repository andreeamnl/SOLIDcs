using System;
using System.Collections.Generic;

namespace DemoLibrary
{
	public interface ITrainingModuleBuilder
	{
        ITrainingModuleBuilder BuildTitle(string title);
        ITrainingModuleBuilder BuildTopics(List<string> topics);
        ITrainingModuleBuilder BuildDuration(string duration);
        ITrainingModuleBuilder BuildDifficultyLevel(string difficultyLevel);
        TrainingModule GetResult();
    }
}

