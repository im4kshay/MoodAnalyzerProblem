using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzerFactory
    {
        // UC4:-CreateMoodAnalyse method to create object of MoodAnalyser class.
        public static Object CreateMoodAnalyze(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not Found");
            }
        }
        // UC5:-For Parameterise constructor by Passing message parameterto the class Method.
        public static object CreateMoodAnalyzerObjectUsingParametzisedConstructor(string className, string constructorName)
        {
            Type type = typeof(MoodAnalyzer);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }
    }
}
