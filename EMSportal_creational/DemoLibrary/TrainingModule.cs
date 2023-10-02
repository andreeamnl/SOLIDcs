using System;
using System.Collections.Generic;

namespace DemoLibrary
{
	public class TrainingModule
	{
        public string Title { get; set; }
        public List<string> Topics { get; set; }
        public string Duration { get; set; }
        public string DifficultyLevel { get; set; }

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

