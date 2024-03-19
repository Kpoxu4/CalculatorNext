﻿using CalculatorNext;
using System;
using System.Text.RegularExpressions;
using System.Threading.Channels;

while (true)
{
    Console.Clear();
    Console.WriteLine("Калькулятор");
    string stringOperation = Console.ReadLine();

    if (stringOperation.Contains(' '))
        stringOperation = string.Join("", stringOperation.Split(' ').ToArray());

    if (stringOperation != "")
    {
        if (stringOperation.Contains('.'))
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        else
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("Ru");

        if (stringOperation[0] == '-' && stringOperation[1] == '-')
            stringOperation = stringOperation.Substring(2);
          
        Regex pattern1 = new Regex(@"([\-]?\d+[\.,]?\d*)([-+*/%])([\-]?\d+[\.,]?\d*)", RegexOptions.Compiled);
        var match1 = pattern1.Match(stringOperation);

        if (match1.Success)
        {
            var leftNumber = double.Parse(match1.Groups[1].Value);
            var operation = char.Parse(match1.Groups[2].Value);
            var rigtNumber = double.Parse(match1.Groups[3].Value);
            Console.Clear();
            Console.WriteLine(Calculat.Arithmetic(leftNumber, operation, rigtNumber));
            Calculat.Info("Продолжим??");
        }
        else if (stringOperation.Contains('^') && stringOperation[stringOperation.Length -1] == '^')
        {
            string leftNumberString = string.Join("", stringOperation.Split('^').ToArray());
            if (int.TryParse(leftNumberString, out int value))
            {
                if (value > 0)
                {
                    Console.Clear();
                    Console.WriteLine(Calculat.Arithmetic(value, '^'));
                    Calculat.Info("Продолжим??");
                }
                else
                    Calculat.Info("Корень берется из положительного числа");
            }

        }
        else
            Calculat.Info("Ввели не верные значения");
    }
    else
        Calculat.Info("надо бы чет ввести =)");
    if (Console.ReadKey().Key == ConsoleKey.Escape)
        break;
}
















