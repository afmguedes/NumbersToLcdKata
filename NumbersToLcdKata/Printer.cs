using System.Collections.Generic;

namespace NumbersToLcdKata
{
    public class Printer
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

            var numberText = number.ToString();

            var result = string.Empty;
            var lcdTextForAllDigits = new List<string[]>();

            foreach (var digitChar in numberText)
            {
                var digit = int.Parse($"{digitChar}");
                var digitLcdText = lcdText[digit].Split('\n');
                lcdTextForAllDigits.Add(digitLcdText);
            }

            for (var line = 0; line < 3; line++)
            {
                for (var digitIndex = 0; digitIndex < numberText.Length; digitIndex++)
                    result += lcdTextForAllDigits[digitIndex][line];

                if (line != 2)
                    result += "\n";
            }

            return result;
        }
    }
}