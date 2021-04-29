using ApiLibrary;
using Calendar_with_jokes;
using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class CalendarTests
    {
        [TestCase(15, false)]
        [TestCase(-2, false)]
        [TestCase(5, true)]
        public void Test_Proper_Month(int month, bool ProperResult)
        {
            MainWindow window = new MainWindow();
            bool result = window.check_the_month(month);
            Assert.AreEqual(ProperResult, result);
        }

        [TestCase(12, 32, false)]
        [TestCase(12, 30, true)]
        [TestCase(2, 28, true)]
        [TestCase(4, 31, false)]
        public void Test_Proper_Day(int month, int day, bool ProperResult)
        {
            MainWindow window = new MainWindow();
            bool result = window.check_the_monthdays(month, day);
            Assert.AreEqual(ProperResult, result);
        }

        [TestCase(13, true)]
        [TestCase(-2, false)]
        [TestCase(2021, true)]
        public void Test_Proper_Year(int year, bool ProperResult)
        {
            MainWindow window = new MainWindow();
            bool result = window.check_the_year(year);
            Assert.AreEqual(ProperResult, result);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Test_TextNull_ReturnFalse(string text)
        {
            ViewDay day = new ViewDay();
            bool result = day.IsNotNull(text);
            Assert.IsFalse(result);
        }

        [TestCase("NotNull")]
        public void Test_TextNotNull_ReturnTrue(string text)
        {
            ViewDay day = new ViewDay();
            bool result = day.IsNotNull(text);
            Assert.IsTrue(result);
        }

        [TestCase("helo",25, true)]
        [TestCase("helo", 3, false)]
        public void Test_String_Proper_Length(string text, int length, bool ProperResult)
        {
            ViewDay day = new ViewDay();
            bool result = day.IsProperLength(text, length);
            Assert.AreEqual(ProperResult, result);
        }

        [Test]
        public void Test_IsJokeSingle()
        {
            ViewDay day = new ViewDay();
            JokeModel jokeinfo = new JokeModel();
            jokeinfo.error = "true";
            Assert.IsTrue(day.IsError(jokeinfo));
        }

        [Test]
        public void Test_JokeWithoutError()
        {
            ViewDay day = new ViewDay();
            JokeModel jokeinfo = new JokeModel();
            jokeinfo.type = "single";
            Assert.IsTrue(day.IsSingle(jokeinfo));
        }
    }

}