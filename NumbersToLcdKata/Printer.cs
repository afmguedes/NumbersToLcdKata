using System.Collections.Generic;
using System.Linq;

namespace NumbersToLcdKata
{
    public class Printer
    {
        public static string ConvertToLcd(int number)
        {
            const char newLine = '\n';

            var lcdTextSingleDigit = new[]
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

            var lcdTextToPrint = string.Empty;
            var inputText = number.ToString();

            var lcdTextForAllDigits = inputText
                .Select(digitChar => (int) char.GetNumericValue(digitChar))
                .Select(digit => lcdTextSingleDigit[digit].Split(newLine))
                .ToList();

            for (var line = 0; line < 3; line++)
            {
                for (var digitIndex = 0; digitIndex < inputText.Length; digitIndex++)
                    lcdTextToPrint += lcdTextForAllDigits[digitIndex][line];

                if (line != 2)
                    lcdTextToPrint += newLine;
            }

            return lcdTextToPrint;
        }
    }
}