namespace CalculatorNext
{
    public class Calculat
    {
        public static string Arithmetic(double x, char arithmetic, double y = 0)
        {
            switch (arithmetic)
            {
                case '+':
                    return $"результат сложения {x} + {y} = {x + y}";
                case '-':
                    return $"результат вычитания {x} - {y} = {x - y}";
                case '*':

                    return $"результат умножения {x} * {y} = {Math.Round(x * y, 3, MidpointRounding.ToEven)}";
                case '/':
                    if (y != 0)
                        return $"результат деления {x} / {y} = {Math.Round(x / y, 3, MidpointRounding.ToEven)}";
                    else
                        return "на ноль делить нельзя";
                case '%':
                    return $" {y} это {Math.Round(y / x * 100, 3, MidpointRounding.ToEven)}% от {x}";
                case '^':
                    return $"корень из числа {x} = {Math.Round(Math.Sqrt(x), 3 , MidpointRounding.ToEven)}";
            }
            return "привет";
        }

        public static void Info(string info)
        {
            Console.WriteLine(info);
            Console.WriteLine("для продолжение нажмите любую кнопку");
            Console.WriteLine("для выхода нажмите ESC");
        }
    }
}
