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
            Console.WriteLine("------------------Anlyse mood with default constructor------------------");
            Console.WriteLine("Write about your mood");
            string mood = Console.ReadLine();
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            Console.WriteLine(moodAnalyser.analyseMood(mood));
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}