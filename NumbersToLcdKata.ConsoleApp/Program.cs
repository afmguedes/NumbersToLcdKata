using System;
using System.Text.RegularExpressions;

namespace NumbersToLcdKata.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string standardModePattern = "print -s \\d+";
            const string customModePattern = "print -c \\d+ \\d+ \\d+";

            Console.WriteLine("== Numbers to LCD text - Kata ==\n");
            ShowHelp();

            string command;

            while (!string.IsNullOrWhiteSpace(command = Console.ReadLine()))
            {
                if (Regex.IsMatch(command, standardModePattern))
                    EnterStandardMode(command);
                else if (Regex.IsMatch(command, customModePattern))
                    EnterCustomMode(command);
                else
                {
                    Console.WriteLine("Invalid command");
                    ShowHelp();
                }
            }
        }

        private static void EnterStandardMode(string command)
        {
            var strippedOutCommand = command.Substring(9);
            var number = int.Parse(strippedOutCommand);

            var lcdText = LcdDisplay.Print(number);
            Console.WriteLine(lcdText);
            Console.Write("> ");
        }

        private static void EnterCustomMode(string command)
        {
            var strippedOutCommand = command.Substring(9);
            var inputValues = strippedOutCommand.Split(' ');
            var number = int.Parse(inputValues[0]);
            var width = int.Parse(inputValues[1]);
            var height = int.Parse(inputValues[2]);

            var lcdText = LcdDisplay.PrintCustomSize(number, width, height);
            Console.WriteLine(lcdText);
            Console.Write("> ");
        }

        private static void ShowHelp()
        {
            Console.WriteLine("usage: print [<options>] [<parameters>]");
            Console.WriteLine("\t-s <number>\t\t\t\tStandard mode");
            Console.WriteLine("\t-c <number> <width> <height>\t\tCustom mode\n\n");
            Console.Write("> ");
        }
    }
}