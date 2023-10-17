using System;
using System.Collections.Generic;

namespace DemoLibrary
{
	public class TrainingModule
	{
        private string Title { get; set; }
        private List<string> Topics { get; set; }
        private string Duration { get; set; }
        private string DifficultyLevel { get; set; }

        public TrainingModule(String Title, List<string> Topics, string Duration, string DifficultyLevel)
        {
            this.Title = Title;
            this.Topics = Topics;
            this.Duration = Duration;
            this.DifficultyLevel = DifficultyLevel;


        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Topics: {string.Join(", ", Topics)}");
            Console.WriteLine($"Duration: {Duration}");
            Console.WriteLine($"Difficulty Level: {DifficultyLevel}");
            Console.WriteLine();
        }
    }
}

