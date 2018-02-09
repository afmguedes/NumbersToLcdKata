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
        public void ReturnExpectedResultInLcdText_WhenConvertToLcdCalledWithSingleDigitNumber(int singleDigitNumber,
            string expectedResult)
        {
            var actual = Printer.ConvertToLcd(singleDigitNumber);

            actual.Should().Be(expectedResult);
        }

        [TestCase(10, "   _ \n || |\n ||_|")]
        [TestCase(11, "    \n | |\n | |")]
        [TestCase(12, "   _ \n | _|\n ||_ ")]
        [TestCase(20, " _  _ \n _|| |\n|_ |_|")]
        [TestCase(1234567890, "   _  _     _  _  _  _  _  _ \n | _| _||_||_ |_   ||_||_|| |\n ||_  _|  | _||_|  ||_| _||_|")]
        public void ReturnExpectedResultInLcdText_WhenConvertToLcdCalledWithMultipleDigitNumber(int multipleDigitNumber,
            string expectedResult)
        {
            var actual = Printer.ConvertToLcd(multipleDigitNumber);

            actual.Should().Be(expectedResult);
        }
    }
}