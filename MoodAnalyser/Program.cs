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
            string str = Console.ReadLine();
            MoodAnalysers analyser = new MoodAnalysers(str);
            Console.WriteLine(analyser.AnalyserMethod());
            Console.WriteLine("\n***************************************************************************\n");
        }
    }
}