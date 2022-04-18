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
            try // Block of Code to be tested for error while it is being executed
            {
                if (this.message.Contains("sad"))//Contains():- This method is used to check whether the substring occurs within a given string or not.
                    return "sad";
                else if (this.message.Contains("happy"))
                    return "happy";
                else if (this.message.Contains(null))
                    return "happy";
            }
            catch // Block of code to be Executed if an error in the block
            {
                return "happy";
            }
            return null; // Value Return for all code path (AnalyzeMood)
        }

    }
}
