using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Простой калькулятор");

        while (true)
        {
            Console.WriteLine("Введите первое число:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите оператор (+, -, *, /):");
            char op = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Перенос строки после ввода оператора

            Console.WriteLine("Введите второе число:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        continue; // Переход к следующей итерации цикла
                    }
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Ошибка: неверный оператор!");
                    continue; // Переход к следующей итерации цикла
            }

            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Продолжить? (да/нет)");
            string answer = Console.ReadLine();
            if (answer.ToLower() != "да")
            {
                break; // Выход из цикла
            }
        }
    }
}