using System.Collections.Specialized;
using NUnit.Framework.Constraints;

namespace NumbersToLcdKata.Tests
{
    internal class LcdNumber
    {
        public static string ConvertToLcd(int number)
        {
            var lcdText = new[]
            {
                " _ \n| |\n|_|",
                "  \n |\n |",
                " _ \n _|\n|_ ",
                " _ \n _|\n _|",
                "   \n|_|\n  |",
                " _ \n|_ \n _|",
                " _ \n|_ \n|_|",
                " _ \n  |\n  |",
                " _ \n|_|\n|_|",
                " _ \n|_|\n _|"
            };

            if (number < 10)
            {
                return lcdText[number];
            }

            var textInput = number.ToString();
            var firstDigit = int.Parse(textInput[0].ToString());
            var secondDigit = int.Parse(textInput[1].ToString());
            var firstDigitLcd = lcdText[firstDigit].Split('\n');
            var secondDigitLcd = lcdText[secondDigit].Split('\n');

            var doubleDigit = firstDigitLcd[0] + secondDigitLcd[0] + "\n" + firstDigitLcd[1] + secondDigitLcd[1] +
                              "\n" + firstDigitLcd[2] + secondDigitLcd[2];
            return doubleDigit;
        }
    }
}