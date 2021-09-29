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
            MoodAnalysers analyser = new MoodAnalysers();
            Console.WriteLine(analyser.AnalyserMethod());
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}