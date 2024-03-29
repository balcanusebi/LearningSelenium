﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WelcomeUser_returns_entered_name()
        {
            var actualMessage = GreetingHelper.GetGreetingMessage("doris");
            var expectedMessage = "Hi doris!";

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TestMethod]
        public void AddToNumber_returns_expected_result()
        {
            var actualSum = MathOperations.GetSum(1,3);
            var expectedSum = 4;

            Assert.AreEqual(expectedSum, actualSum);
        }
    }
}
