using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerCustomException : Exception // Exception:Represent error that occur during application Execution
    {
        // Enum for Exception Type
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE, NO_SUCH_FIELD, NO_SUCH_METHOD,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
        }

        //creating 'type' variable of the type ExceptionType
        public readonly ExceptionType type;

        // Parameterized constructor sets the Exception Type and message
        public MoodAnalyzerCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
