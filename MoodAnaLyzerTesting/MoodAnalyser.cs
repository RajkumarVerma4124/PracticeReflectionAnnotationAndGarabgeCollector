using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProgram;
using System;

namespace MoodAnaLyzerTesting
{
    [TestClass]
    public class MoodAnalyser
    {
        [TestCategory("Exception")]
        [TestMethod]
        public void GivenHappyMessageReturnHappyMood()
        {
            ///AAA
            ///Arange
            string msg = "I am in HAPPY Mood";
            string expected = "happy";
            MoodAnalyzer mood = new MoodAnalyzer(msg);

            ///Act
            string actual = mood.AnalyserMood();

            ///Asert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Exception")]
        [TestMethod]
        public void GivenSadMessageReturnSadMood()
        {
            ///AAA
            ///Arange
            string msg = "I am in SAD Mood";
            string expected = "sad";
            MoodAnalyzer mood = new MoodAnalyzer(msg);

            ///Act
            string actual = mood.AnalyserMood();

            ///Asert
            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Exception")]
        [TestMethod]
        public void GivenNullMessageReturnHappyMood()
        {
            ///AAA
            ///Arange
            string msg = null;
            string expected = "happy";
            string actual = null;
            MoodAnalyzer mood = new MoodAnalyzer(msg);

            try
            {
                ///Act
                actual = mood.AnalyserMood();
            }
            catch (NullReferenceException ex)
            {
                ///Asert
                Assert.AreEqual(expected, ex.Message);
            }

            ///Asert
            Assert.AreEqual(expected, actual);
        }


        [TestCategory("Exception")]
        [TestMethod]
        public void GivenNullMessageReturnException()
        {
            ///AAA
            ///Arange
            string msg = null;
            string expected = "Object reference not set to an instance of objec";
            MoodAnalyzer mood = new MoodAnalyzer(msg);
            try
            {
                ///Act
                string actual = mood.AnalyserMood();
            }
            catch (NullReferenceException ex)
            {
                ///Asert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Exception")]
        [TestMethod]
        public void GivenNullMessageReturnCustomException()
        {
            ///AAA
            ///Arange
            string msg = null;
            string expected = "Message should not be null";
            MoodAnalyzer mood = new MoodAnalyzer(msg);
            try
            {
                ///Act
                string actual = mood.AnalyserMood();
            }
            catch (MoodAnalyserException ex)
            {
                ///Asert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestCategory("Exception")]
        [TestMethod]
        public void GivenEmptyMessageReturnCustomException()
        {
            ///AAA
            ///Arange
            string msg = null;
            string expected = "Message should not be empty";
            MoodAnalyzer mood = new MoodAnalyzer(msg);
            try
            {
                ///Act
                string actual = mood.AnalyserMood();
            }
            catch (MoodAnalyserException ex)
            {
                ///Asert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
