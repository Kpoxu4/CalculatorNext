using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorNext
{
    public class Calculat
    {
        public static double Arithmetic(double x, double y, char arithmetic)
        {
            double result = 0;
            switch (arithmetic)
            {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    if (y != 0)
                        result = x / y;
                    break;
            }
            return result;
        }

        public static void Info(string info)
        {
            Console.WriteLine(info);
            Console.WriteLine("для продолжение нажмите любую кнопку");
            Console.WriteLine("для выхода нажмите ESC");
        }
    }
}
