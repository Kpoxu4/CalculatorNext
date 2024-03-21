namespace CalculatorNext
{
    public class Calculate
    {
        public static string Arithmetic(double x, string arithmetic, double y = 0)
        {
            switch (arithmetic)
            {
                case "+":
                    return $"результат сложения\n{x} + {y} = {x + y}";
                case "-":
                    return $"результат вычитания\n{x} - {y} = {x - y}";
                case "*":

                    return $"результат умножения\n{x} * {y} = {Math.Round(x * y, 3, MidpointRounding.ToEven)}"; 
                case "/":
                    if (y != 0)
                        return $"результат деления\n{x} / {y} = {Math.Round(x / y, 3, MidpointRounding.ToEven)}";
                    else
                        return "на ноль делить нельзя";
                case "%":
                    return $" {x}% от {y} это {Math.Round(y * x / 100, 3, MidpointRounding.ToEven)}";
                case "sqrt":
                    return $"корень из числа\n{x} = {Math.Round(Math.Sqrt(x), 3 , MidpointRounding.ToEven)}";
            }
            return "что - то пошло не так";
        }

        public static void Info(string info)
        {
            Console.WriteLine("\n" + info);
            Console.WriteLine("для продолжение нажмите любую кнопку");
            Console.WriteLine("для выхода нажмите ESC");
        }
        public static void Info()
        {
            Console.WriteLine("Калькулятор\nВыполняет простые арифметические действия\n" +
                "Для вычисления корня числа используйте ^: например 25^ будет ровно 5\n" +
                "Для вычисления процента  используйте %: например 10%100 будет ровно 10\n");
        } 
    }
}
