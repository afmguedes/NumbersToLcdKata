using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumbersToLcdKata
{
    public class DisplayDigit
    {
        public string LineOneOutput { get; }
        public string LineTwoOutput { get; }
        public string LineThreeOutput { get; }

        private DisplayDigit(string lineOneOutput, string lineTwoOutput, string lineThreeOutput)
        {
            LineOneOutput = lineOneOutput;
            LineTwoOutput = lineTwoOutput;
            LineThreeOutput = lineThreeOutput;
        }

        public static DisplayDigit Zero = new DisplayDigit(" _ ", "| |", "|_|");
        public static DisplayDigit One = new DisplayDigit("  ", " |", " |");
        public static DisplayDigit Two = new DisplayDigit(" _ ", " _|", "|_ ");
        public static DisplayDigit Three = new DisplayDigit(" _ ", " _|", " _|");
        public static DisplayDigit Four = new DisplayDigit("   ", "|_|", "  |");
        public static DisplayDigit Five = new DisplayDigit(" _ ", "|_ ", " _|");
        public static DisplayDigit Six = new DisplayDigit(" _ ", "|_ ", "|_|");
        public static DisplayDigit Seven = new DisplayDigit(" _ ", "  |", "  |");
        public static DisplayDigit Eight = new DisplayDigit(" _ ", "|_|", "|_|");
        public static DisplayDigit Nine = new DisplayDigit(" _ ", "|_|", " _|");

        private const char NewLine = '\n';

        public static Dictionary<int, DisplayDigit> Digits = new Dictionary<int, DisplayDigit>()
        {
            { 0, Zero },
            { 1, One },
            { 2, Two },
            { 3, Three },
            { 4, Four },
            { 5, Five },
            { 6, Six },
            { 7, Seven },
            { 8, Eight },
            { 9, Nine },
        };

        public static string PrintDigits(IEnumerable<DisplayDigit> digits)
        {
            var lineOne = PrintLine(digits, d => d.LineOneOutput);
            var lineTwo = PrintLine(digits, d => d.LineTwoOutput);
            var lineThree = PrintLine(digits, d => d.LineThreeOutput);

            return lineOne + NewLine + lineTwo + NewLine + lineThree;
        }

        private static string PrintLine(IEnumerable<DisplayDigit> digits, Func<DisplayDigit, string> lineSelector)
        {
            return string.Join(string.Empty, digits.Select(lineSelector));
        }
    }
}
