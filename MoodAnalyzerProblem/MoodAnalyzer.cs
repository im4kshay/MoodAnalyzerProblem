using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer()
        {

        }

        /// Parameterised Constructor.
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
   
        ///UC1:-Analyse Happy And Sad Mood
        ///if messege Contain Sad then return Sad
        ///if message contain Happy then return Happy
        
        public string AnalyzeMood()
        {
            if (this.message.ToLower().Contains("sad")) //Contains():- This method is used to check whether the substring occurs within a given string or not.
                return "sad";
            else
                return "happy";

            //return null;
        }

    }
}
