using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalysers
    {
        public string message;
        public MoodAnalysers()
        {
            this.message = "I am in Sad mood";
        }
        /// <summary>
        /// Parameterised Constructor
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalysers(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Mood Analyser check Happy or sad
        /// </summary>
        /// <returns></returns>
        public string AnalyserMethod()
        {
            string[] mood = message.Split(" ");
            for (int i = 0; i < mood.Length; i++)
            {
                if (mood[i].ToLower() == "sad")
                {
                    return "SAD";
                }
                else if(mood[i].ToLower() == "happy")
                {
                    return "SAD";
                }
            }
            return "HAPPY";
        }
    }
}