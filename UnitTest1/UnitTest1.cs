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

                MoodAnalysers moodAnalyzer = new MoodAnalysers(" ");
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
        /// <summary>
        /// Test case 4.1, create a MoodAnalyser Object with default constructor and check if the two objects are equal
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
        {
            string message = null;
            object expected = new MoodAnalysers(message);
            object obj = ReflectionMoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalysers", "MoodAnalysers");
            expected.Equals(obj);
        }
        /// <summary>
        /// Test case 4.2, pass wrong class name catch Exception and throw Exception indicating No Such Class Error
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]

        public void GivenWrongClassName_ShouldThrowException()
        {
            string message = null;
            object expected = new MoodAnalysers(message);
            object obj = ReflectionMoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.moodanalysers", "MoodAnalysers");
            expected.Equals(obj);
        }
        /// <summary>
        /// Test case 4.3, pass wrong Constructor parameter, catch the Exception and throw indicating No Such Method Error
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(MoodAnalyserCustomException))]
        public void GivenClassConstructerNotProper_ShouldThrowException()
        {
            string message = null;
            object expected = new MoodAnalysers(message);
            object obj = ReflectionMoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.Moodanalysers", "MoodAnalysers(int)");
            expected.Equals(obj);
        }
    }
}