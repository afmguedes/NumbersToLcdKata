using FluentAssertions;
using NUnit.Framework;

namespace NumbersToLcdKata.Tests.LcdDisplayUnitTests
{
    public class PrintCustomSizeShould
    {
        [TestCase(2, 1, 1, " _ \n  |\n _ \n|  \n _ ")]
        [TestCase(2, 3, 2, " ___ \n    |\n    |\n ___ \n|    \n|    \n ___ ")]
        [TestCase(3, 3, 3, " ___ \n    |\n    |\n    |\n ___ \n    |\n    |\n    |\n ___ ")]
        public void ReturnExpectedResultInLcdText_WhenCalledWithOneDigitNumber(int singleDigitNumber,
            int width, int height, string expectedResult)
        {
            var actual = LcdDisplay.PrintCustomSize(singleDigitNumber, width, height);

            actual.Should().Be(expectedResult);
        }

        [TestCase(59, 3, 2, " ___  ___ \n|    |   |\n|    |   |\n ___  ___ \n    |    |\n    |    |\n ___  ___ ")]
        [TestCase(123, 2, 1, "     __  __ \n   |   |   |\n   | __  __ \n   ||      |\n   | __  __ ")]
        [TestCase(1234567890, 1, 1,
            "    _  _     _  _  _  _  _  _ \n  |  |  || ||  |    || || || |\n  | _  _  _  _  _   | _  _ | |\n  ||    |  |  || |  || |  || |\n  | _  _   | _  _   | _  _  _ ")]
        public void ReturnExpectedResultInLcdText_WhenCalledWithMultipleDigitNumber(int multipleDigitNumber,
            int width, int height, string expectedResult)
        {
            var actual = LcdDisplay.PrintCustomSize(multipleDigitNumber, width, height);

            actual.Should().Be(expectedResult);
        }
    }
}