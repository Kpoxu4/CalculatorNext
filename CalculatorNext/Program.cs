using CalculatorNext;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

while (true) 
{
    Console.Clear();
    Console.WriteLine("Калькулятор");
    string operation = Console.ReadLine();

    if (operation.Contains(' '))
        operation = string.Join("", operation.Split(' ').ToArray());

    if (operation != "")
    {
        if (operation.Contains('.'))
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        else
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("Ru");

        if (operation[0] == '-' && operation[1] == '-')
            operation = operation.Substring(2);

        Regex pattern = new Regex(@"([\-]?\d+[\.,]?\d*)([-+*/])([\-]?\d+[\.,]?\d*)", RegexOptions.Compiled);
        var match = pattern.Match(operation);
        double result = 0;

        if (match.Success)
        {
            var a = double.Parse(match.Groups[1].Value);
            var b = char.Parse(match.Groups[2].Value);
            var c = double.Parse(match.Groups[3].Value);
            if (b == '/' && c == 0)
                Calculat.Info("на ноль делить нельзя");
            else
            {
                result = Calculat.Arithmetic(a, c, b);
                Console.Clear();
                Console.WriteLine($"{a} {b} {c} = {Math.Round(result, 3, MidpointRounding.ToEven)}");
                Calculat.Info("Успех");
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
















