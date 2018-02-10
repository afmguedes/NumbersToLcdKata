using System;
using System.Collections.Generic;
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
    }
}