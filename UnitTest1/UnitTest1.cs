using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers("I am in sad mood");
            //Act
            var result = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("Sad", result);
        }
        [TestMethod]
        public void TestMethod2()
        {

            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers("I am in any mood");
            //Act
            var result = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("Happy", result);
        }
    }
}