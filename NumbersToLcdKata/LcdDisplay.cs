using System;
using System.Linq;

namespace NumbersToLcdKata
{
    public class LcdDisplay
    {
        public static string Print(int number)
        {
            var numberDigits = number.ToString().Select(c => DisplayDigit.Digits[(int) char.GetNumericValue(c)]);

            return DisplayDigit.PrintDigits(numberDigits);
        }

        public static string PrintCustomSize(int number, int width, int height)
        {
            var numberCustomDigits = number.ToString().Select(c => DisplayCustomDigit.CustomDigits[(int)char.GetNumericValue(c)]);

            return DisplayCustomDigit.PrintDigits(numberCustomDigits, width, height);
        }
    }
}