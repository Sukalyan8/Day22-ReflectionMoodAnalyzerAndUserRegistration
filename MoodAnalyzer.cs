using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer_Reflection
{
    public class MoodAnalyzer
    {
        public string message;
        //public MoodAnalyser()
        //{
        //}

        public void MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            string mood;
            if (message == "I am in a Happy mood")
                mood = "Happy";
            else if (message == "I am in a Sad mood")
                mood = "Sad";
            else
                mood = null;
            return mood;
        }
    }
}