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
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("I am in Sad Mood");
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
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("I am in Happy Mood");
            //Assert
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }
        //UC1 Repeat TC1.1:-Message in the constructor should return sad
        [TestMethod]
        public void Given_I_Am_In_Sad_Mood_Should_Return_SAD()
        {
            //Arrange
            string message = "I am in SAD mood.";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
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
            string message = "I am in HAPPY mood.";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
            //Act
            string result = moodAnalyser.AnalyzeMood();
            //Assert
            Assert.AreEqual("happy", result);
        }
    }
}
