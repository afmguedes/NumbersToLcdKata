using System;
using System.Globalization;

namespace NumbersToLcdKata.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (int.TryParse(Console.ReadLine(), out var number))
            {
                var lcdText = LcdDisplay.Print(number);
                Console.WriteLine(lcdText);
            }
        }
    }
}
