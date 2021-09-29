using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class MoodAnalyser
    {
        public string toCheckMood(string str)
        {
            string[] mood = str.Split(" ");
            for(int i=0; i<mood.Length; i++)
            {
                if (mood[i].ToLower() == "sad")
                {
                    return "SAD";
                }
            }
            return "Happy";
        }
    }
}
