using System;

namespace MoodAnalyser
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
            MoodAnalysers moodAnalyser = new MoodAnalysers(mood);
            Console.WriteLine(moodAnalyser.AnalyserMethod());
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}