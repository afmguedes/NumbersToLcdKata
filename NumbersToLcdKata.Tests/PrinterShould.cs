using FluentAssertions;
using NUnit.Framework;

namespace NumbersToLcdKata.Tests
{
    [TestFixture]
    public class PrinterShould
    {
        [TestCase(1, "  \n |\n |")]
        [TestCase(2, " _ \n _|\n|_ ")]
        [TestCase(3, " _ \n _|\n _|")]
        [TestCase(4, "   \n|_|\n  |")]
        [TestCase(5, " _ \n|_ \n _|")]
        [TestCase(6, " _ \n|_ \n|_|")]
        [TestCase(7, " _ \n  |\n  |")]
        [TestCase(8, " _ \n|_|\n|_|")]
        [TestCase(9, " _ \n|_|\n _|")]
        [TestCase(0, " _ \n| |\n|_|")]
        public void ReturnExpectedResultInLcdText_WhenPrintCalledWithSingleDigitNumber(int singleDigitNumber,
            string expectedResult)
        {
            var actual = LcdDisplay.Print(singleDigitNumber);

            actual.Should().Be(expectedResult);
        }

        [TestCase(10, "   _ \n || |\n ||_|")]
        [TestCase(11, "    \n | |\n | |")]
        [TestCase(1234567890,
            "   _  _     _  _  _  _  _  _ \n | _| _||_||_ |_   ||_||_|| |\n ||_  _|  | _||_|  ||_| _||_|")]
        public void ReturnExpectedResultInLcdText_WhenPrintCalledWithMultipleDigitNumber(int multipleDigitNumber,
            string expectedResult)
        {
            var actual = LcdDisplay.Print(multipleDigitNumber);

            actual.Should().Be(expectedResult);
        }

        [TestCase(2, 1, 1, " _ \n  |\n _ \n|  \n _ ")]
        [TestCase(2, 3, 2, " ___ \n    |\n    |\n ___ \n|    \n|    \n ___ ")]
        [TestCase(3, 3, 3, " ___ \n    |\n    |\n    |\n ___ \n    |\n    |\n    |\n ___ ")]
        public void ReturnExpectedResultInLcdText_WhenPrintCustomSizeCalledWithOneDigitNumber(int singleDigitNumber,
            int width, int height, string expectedResult)
        {
            var actual = LcdDisplay.PrintCustomSize(singleDigitNumber, width, height);

            actual.Should().Be(expectedResult);
        }

        [TestCase(59, 3, 2, " ___  ___ \n|    |   |\n|    |   |\n ___  ___ \n    |    |\n    |    |\n ___  ___ ")]
        [TestCase(123, 2, 1, "     __  __ \n   |   |   |\n   | __  __ \n   ||      |\n   | __  __ ")]
        [TestCase(1234567890, 1, 1, "    _  _     _  _  _  _  _  _ \n  |  |  || ||  |    || || || |\n  | _  _  _  _  _   | _  _ | |\n  ||    |  |  || |  || |  || |\n  | _  _   | _  _   | _  _  _ ")]
        public void ReturnExpectedResultInLcdText_WhenPrintCustomSizeCalledWithMultipleDigitNumber(int multipleDigitNumber,
            int width, int height, string expectedResult)
        {
            var actual = LcdDisplay.PrintCustomSize(multipleDigitNumber, width, height);

            actual.Should().Be(expectedResult);
        }
    }
}