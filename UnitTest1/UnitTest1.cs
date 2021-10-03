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
            MoodAnalysers moodAnalyser = new MoodAnalysers();
            //Act
            var result = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("SAD", result);
        }
        [TestMethod]
        public void TestMethod2()
        {

            //Arrange
            MoodAnalysers moodAnalyser = new MoodAnalysers("I am in Happy mood");
            //Act
            var result = moodAnalyser.AnalyserMethod();
            //Assert
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            try
            {

                MoodAnalysers moodAnalyzer = new MoodAnalysers("");
                string mood = moodAnalyzer.AnalyserMethod();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            try
            {
                MoodAnalysers moodAnalyzer = new MoodAnalysers(null);
                string mood = moodAnalyzer.AnalyserMethod();
            }
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }
    }
}