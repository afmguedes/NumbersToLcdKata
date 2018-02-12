using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersToLcdKata
{
    public class DisplayCustomDigit
    {
        private const char NewLine = '\n';

        public static DisplayCustomDigit Zero = new DisplayCustomDigit(" _ ", "| |", "| |", "| |", " _ ");
        public static DisplayCustomDigit One = new DisplayCustomDigit("   ", "  |", "  |", "  |", "  |");
        public static DisplayCustomDigit Two = new DisplayCustomDigit(" _ ", "  |", " _ ", "|  ", " _ ");
        public static DisplayCustomDigit Three = new DisplayCustomDigit(" _ ", "  |", " _ ", "  |", " _ ");
        public static DisplayCustomDigit Four = new DisplayCustomDigit("   ", "| |", " _ ", "  |", "  |");
        public static DisplayCustomDigit Five = new DisplayCustomDigit(" _ ", "|  ", " _ ", "  |", " _ ");
        public static DisplayCustomDigit Six = new DisplayCustomDigit(" _ ", "|  ", " _ ", "| |", " _ ");
        public static DisplayCustomDigit Seven = new DisplayCustomDigit(" _ ", "  |", "  |", "  |", "  |");
        public static DisplayCustomDigit Eight = new DisplayCustomDigit(" _ ", "| |", " _ ", "| |", " _ ");
        public static DisplayCustomDigit Nine = new DisplayCustomDigit(" _ ", "| |", " _ ", "  |", " _ ");

        public static Dictionary<int, DisplayCustomDigit> CustomDigits = new Dictionary<int, DisplayCustomDigit>
        {
            {0, Zero},
            {1, One},
            {2, Two},
            {3, Three},
            {4, Four},
            {5, Five},
            {6, Six},
            {7, Seven},
            {8, Eight},
            {9, Nine}
        };

        private DisplayCustomDigit(string topLine, string topHalf, string midLine, string btmHalf, string btmLine)
        {
            TopLine = topLine;
            TopHalf = topHalf;
            MidLine = midLine;
            BtmHalf = btmHalf;
            BtmLine = btmLine;
        }

        public string TopLine { get; }
        public string TopHalf { get; }
        public string MidLine { get; }
        public string BtmHalf { get; }
        public string BtmLine { get; }

        public static string PrintDigits(IEnumerable<DisplayCustomDigit> digits, int width, int height)
        {
            var topLine = PrintSection(digits, width, d => d.TopLine);
            var topHalf = PrintSection(digits, width, d => d.TopHalf);
            var midLine = PrintSection(digits, width, d => d.MidLine);
            var btmHalf = PrintSection(digits, width, d => d.BtmHalf);
            var btmLine = PrintSection(digits, width, d => d.BtmLine);

            return topLine + NewLine + string.Concat(Enumerable.Repeat(topHalf + NewLine, height)) + midLine +
                   NewLine + string.Concat(Enumerable.Repeat(btmHalf + NewLine, height)) + btmLine;
        }

        private static string PrintSection(IEnumerable<DisplayCustomDigit> digits, int width,
            Func<DisplayCustomDigit, string> sectionSelector)
        {
            return string.Join(string.Empty,
                digits.Select(sectionSelector).Select(s => s[0] + new string(s[1], width) + s[2]));
        }
    }
}