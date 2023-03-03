using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN;
            {
                switch (op)
                {
                    case "a":
                        result = num1 + num2;
                        break;
                    case "s":
                        result = num1 - num2;
                        break;
                    case "m":
                        result = num1 * num2;
                        break;
                    case "d":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        break;
                }
                return result;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                bool endApp = false;
                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------------\n");
                while (!endApp)
                {
                    string numInput1 = "";
                    string numInput2 = "";
                    double result = 0;
                    Console.Write("Введите число и нажмите клавишу Enter: ");
                    numInput1 = Console.ReadLine();
                    double cleanNum1 = 0;
                    while (!double.TryParse(numInput1, out cleanNum1))
                    {
                        Console.Write("Это недопустимый ввод. Пожалуйста, введите целое число: ");
                        numInput1 = Console.ReadLine();
                    }
                    Console.Write("Введите другое число, а затем нажмите Enter: ");
                    numInput2 = Console.ReadLine();
                    double cleanNum2 = 0;
                    while (!double.TryParse(numInput2, out cleanNum2))
                    {
                        Console.Write("Это недопустимый ввод. Пожалуйста, введите целое число: ");
                        numInput2 = Console.ReadLine();
                    }
                    Console.WriteLine("Выберите оператора из следующего списка:");
                    Console.WriteLine("\ta - Прибавление");
                    Console.WriteLine("\ts - Вычитание");
                    Console.WriteLine("\tm - Умножение");
                    Console.WriteLine("\td - Деление");
                    Console.Write("Ваш вариант? ");
                    string op = Console.ReadLine();
                    try
                    {
                        result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("Эта операция приведет к математической ошибке.\n");
                        }
                        else Console.WriteLine("Ваш результат {0:0.##}\n", result);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Произошло исключение при попытке выполнить вычисления.\n - Details: " + e.Message);
                    }
                    Console.WriteLine("------------------------\n");
                    Console.Write("Нажмите «n» и Enter, чтобы закрыть приложение, или нажмите любую другую клавишу и Enter, чтобы продолжить: ");
                    if (Console.ReadLine() == "n") endApp = true;
                    Console.WriteLine("\n");
                }
                return;
            }
        }
    }
}
