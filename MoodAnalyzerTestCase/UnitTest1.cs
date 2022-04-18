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
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("I am in sad Mood");
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
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("I am in happy Mood");
            //Assert
            Assert.AreEqual(expected, moodAnalyser.AnalyzeMood());
        }
        //UC1 Repeat TC1.1:-Message in the constructor should return sad
        [TestMethod]
        public void Given_I_Am_In_Sad_Mood_Should_Return_SAD()
        {
            //Arrange
            string message = "I am in sad mood.";
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
            string message = "I am in happy mood.";
            MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
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
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("");
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
                MoodAnalyzer moodAnalyser = new MoodAnalyzer(message);
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
            MoodAnalyzer moodAnalyser = new MoodAnalyzer("");
            string actual = moodAnalyser.AnalyzeMood();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
