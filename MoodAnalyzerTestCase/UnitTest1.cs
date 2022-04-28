using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;
using System;

namespace MoodAnalyzerTestCase
{
    [TestClass]
    public class UnitTest1
    {
        //UC1 TC1.1:-Respond Sad Mood
        [TestMethod]
        public void Method_Return_Sad()
        {
            //Arrange
            string expected = "sad";
            //Act
            MoodAnalyzerProblem.MoodAnalyzer moodAnalyser = new MoodAnalyzerProblem.MoodAnalyzer("I am in sad Mood");
            //Assert
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }
        //UC1 TC1.2:-Respond Happy Mood
        [TestMethod]
        public void Method_Return_Happy()
        {
            //Arrange
            string expected = "happy";
            //Act
            MoodAnalyzerProblem.MoodAnalyzer moodAnalyser = new MoodAnalyzerProblem.MoodAnalyzer("I am in happy Mood");
            //Assert
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }
        //UC1 Repeat TC1.1:-Message in the constructor should return sad
        [TestMethod]
        public void Given_I_Am_In_Sad_Mood_Should_Return_SAD()
        {
            //Arrange
            string message = "I am in sad mood.";
            MoodAnalyzerProblem.MoodAnalyzer moodAnalyser = new MoodAnalyzerProblem.MoodAnalyzer(message);
            //Act
            string result = moodAnalyser.AnalyzeMood();
            //Assert
            Assert.AreEqual("sad", result);
        }
        //UC1 Repeat TC1.2:-Message in the constructor should return happy
        [TestMethod]
        public void Given_I_Am_In_Happy_Mood_Should_Return_HAPPY()
        {
            //Arrange
            string message = "I am in happy mood.";
            MoodAnalyzerProblem.MoodAnalyzer moodAnalyser = new MoodAnalyzerProblem.MoodAnalyzer(message);
            //Act
            string result = moodAnalyser.AnalyzeMood();
            //Assert
            Assert.AreEqual("happy", result);
        }
        //UC2 TC2.1:-Null mood Should Return Happy
        [TestMethod]
        public void NullMood_Return_Happy()
        {
            //Arrange
            string expected = "Mood should not be Empty";
            //Act
            MoodAnalyzerProblem.MoodAnalyzer moodAnalyser = new MoodAnalyzerProblem.MoodAnalyzer("");
            string actual = moodAnalyser.AnalyzeMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        //TC3.1:-Given empty mood should Thow Mood AnalysisException Indicating Empty mood
        [TestMethod]
        public void Given_Empty_Mood_Should_Thow_Mood_AnalysisException_Indicating_Empty_Mood()
        {
            try
            {
                string message = "";
                MoodAnalyzerProblem.MoodAnalyzer moodAnalyser = new MoodAnalyzerProblem.MoodAnalyzer(message);
                string mood = moodAnalyser.AnalyzeMood();
            }
            catch (MoodAnalyzerCustomException e)
            {
                Assert.AreEqual("Mood Should not be Empty", e.Message);
            }
        }
        [TestMethod]
        //TC3.2:-Empty mood Should throw Empty Mood
        public void GivenEmptyUsingCustomException()
        {
            //Arrange
            string expected = "Mood should not be Empty";
            //Act
            MoodAnalyzerProblem.MoodAnalyzer moodAnalyser = new MoodAnalyzerProblem.MoodAnalyzer("");
            string actual = moodAnalyser.AnalyzeMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        //TC4.1:-Given MoodAnalyser Class Name Should Return Mood Anlayser Object
        public void GivenMoodAnalyserClassName_WhenAnalyse_ShouldReturnObject()
        {
            //Arrange
            //string message = null;
            //Act
            MoodAnalyzer expected = new MoodAnalyzer();
            object resultobj = MoodAnalyzerFactory.CreateMoodAnalyze("MoodAnalyzerProblem.MoodAnalyzer", "MoodAnalyzer");
            //Assert
            expected.Equals(resultobj);
        }
        [TestMethod]
        //TC4.2:-Given class Name when improper should throw MoodAnalyserCustomException
        public void Given_Improper_Class_Name_Should_Throw_MoodAnalyzerCustomException_Indicating_No_Such_Class()
        {
            try
            {
                //Arrange
                string className = "WrongNamespace.MoodAnalyzer";
                string constructorName = "MoodAnalyzer";
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyze(className, constructorName);
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        [TestMethod]
        //TC4.3:-Given class when constructor improper should throw MoodAnalysisException
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalyzerCustomException_Indicating_No_Such_Constuctor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzer.MoodAnalyzer";
                string constructorName = "WrongConstructorName";
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyze(className, constructorName);
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not Found", e.Message);
            }
        }
        //TC5.1:-Given MoodAnlayser when proper return MoodAnalyser Object
        [TestMethod]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parametrized_Constructor()
        {

            //Arrange
            string className = "MoodAnalyzerProblem.MoodAnalyzer";
            string constructorName = "MoodAnalyzer";
            string message = "Happy";
            MoodAnalyzer expectedObj = new MoodAnalyzer("HAPPY");
            //Act
            object resultObj = MoodAnalyzerFactory.CreateMoodAnalyzerObjectUsingParametzisedConstructor(className, constructorName, message);
            //Assert
            expectedObj.Equals(resultObj);
        }
        //TC5.2:-Pass Wrong Class Name Catch exception and throw Exception indicating No such class error
        [TestMethod]
        public void Given_Wrong_Class_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "WrongNameSpace.MoodAnalyzer";
                string constructorName = "MoodAnalyser";
                string message = "Happy";
                MoodAnalyzer expectedObj = new MoodAnalyzer("HAPPY");
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyzerObjectUsingParametzisedConstructor(className, constructorName, message);
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        //TC5.3:-Pass Wrong Constructor parameter, cactch the Exception and throw indicating No such method Error
        [TestMethod]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzerProblem.MoodAnalyzer";
                string constructorName = "WrongConstructorName";
                string message = "Happy";
                MoodAnalyzer expectedObj = new MoodAnalyzer("HAPPY");
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyzerObjectUsingParametzisedConstructor(className, constructorName, message);
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not Found", e.Message);
            }
        }
        //TC6.1:-Invoke Analyse Method and Show Happy Mood
        [TestMethod]
        public void Given_Happy_Message_Using_Reflection_When_Proper_Should_Return_Happy()
        {
            //Arrange
            string message = "Happy";
            string methodName = "AnalyzeMood";
            //Act
            string actual = MoodAnalyzerFactory.InvokeAnalyzeMood(message, methodName);
            //Assert
            Assert.AreEqual("happy", actual);
        }
        //TC6.2:-Pass Wrong Method Should Throw MoodAnalyserCustomException
        [TestMethod]
        public void Given_Improper_Method_Name_Throw_MoodAnalyserCustomException_Indicating_No_Such_Method()
        {
            try
            {
                //Arrange
                string message = "Happy";
                string methodName = "WrongMethodName";
                //Act
                string actual = MoodAnalyzerFactory.InvokeAnalyzeMood(message, methodName);
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("No Such Method", e.Message);
            }
        }

    }
}
