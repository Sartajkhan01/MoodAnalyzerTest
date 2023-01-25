using MoodAnalyzerProg;

namespace MoodAnalyserNunitTest
{
    [TestClass]
    public class Tests
    {
        MoodAnalyser moodAnalyser;
        [TestMethod]
        public void Setup()
        {
            moodAnalyser = new MoodAnalyser();
        }
        /// <summary>
        /// TC1.1 Given “I am in Sad Mood” message Should Return SAD
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenSad_ShouldReturnSadParameterLess_Constructor()
        {
            //Arrange
            moodAnalyser = new MoodAnalyser();
            string msg = "I am in SAD mood";
            //Act
            string message = moodAnalyser.AnalyseMoodWithoutConstructor(msg);
            //Assert
            Assert.AreEqual("SAD", message);
        }
        /// <summary>
        /// TC1.2 Given “I am in Any Mood” message Should Return HAPPY
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenAnyMood_ShouldReturnHappyParameterLess_Constructor()
        {
            moodAnalyser = new MoodAnalyser();
            string msg = "I am in Any mood";
            string message = moodAnalyser.AnalyseMoodWithoutConstructor(msg);
            Assert.AreEqual("HAPPY", message);
        }
        /// <summary>
        /// TC1.1 Given “I am in Sad Mood” message in Constructor Should Return SAD
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenSad_ShouldReturnSad()
        {
            moodAnalyser = new MoodAnalyser("I am in Sad mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("SAD", message);
        }
        /// <summary>
        /// TC1.2 Given “I am in Happy Mood” message in Constructor Should Return SAD
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenHappy_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser("I am in Happy mood");
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }
        //UC-2
        /// <summary>
        /// TC2.1Given Null Mood Should Return Happy To make this Test Case pass Handle
        /// NULL Scenario using try catch and return Happy
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenNull_ShouldReturnHappy()
        {
            moodAnalyser = new MoodAnalyser();
            string message = moodAnalyser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }
        //UC-3
        /// <summary>
        /// TC3.1 Given NULL Mood Should Throw MoodAnalysisException To pass this Test Case
        /// in try catch block throw MoodAnalysisException
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenNull_USingCustomException_ShouldReturnNullMood()
        {
            moodAnalyser = new MoodAnalyser();
            try
            {
                string message = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(MoodAnalyserCustomException.ExceptionType.NULL_MOOD, exception.exceptionType);
            }

        }
        /// <summary>
        /// TC3.2 Given Empty Mood Should Throw MoodAnalysisException indicating Empty Mood 
        /// Handle Empty Mood Scenario throw MoodAnalysisException and inform user of the EmptyMood 
        /// HINT: Use Enum to EMPTY or NULL
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenEmpty_USingCustomException_ShouldReturnNullMood()
        {
            moodAnalyser = new MoodAnalyser("");
            try
            {
                string message = moodAnalyser.AnalyseMood();
            }
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(MoodAnalyserCustomException.ExceptionType.EMPTY_MOOD, exception.exceptionType);
            }
        }
    }
}