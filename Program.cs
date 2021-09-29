using System;

namespace MoodAnalyserProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************************************************\n");
            Console.WriteLine("Welcome to Mood Analyser Problem");
            Console.WriteLine("\n***************************************************************************\n");
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Console.WriteLine("Write about your mood");
            string mood = Console.ReadLine();
            Console.WriteLine(moodAnalyser.toCheckMood(mood));
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}
