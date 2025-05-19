using System;

class Program
{
    static void Main()
    {
        double num1, num2;
        string operation;

        Console.Write("Введите первое число: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nВыберите операцию:");
        Console.WriteLine("+  -> Сложение");
        Console.WriteLine("-  -> Вычитание");
        Console.WriteLine("*  -> Умножение");
        Console.WriteLine("/  -> Деление");
        Console.WriteLine("%  -> Остаток от деления");
        Console.WriteLine("++ -> Инкремент первого числа");
        Console.WriteLine("-- -> Декремент первого числа");
        Console.Write("Введите операцию: ");
        operation = Console.ReadLine();

        if (operation == "+")
        {
            Console.WriteLine($"Результат: {num1} + {num2} = {num1 + num2}");
        }
        else if (operation == "-")
        {
            Console.WriteLine($"Результат: {num1} - {num2} = {num1 - num2}");
        }
        else if (operation == "*")
        {
            Console.WriteLine($"Результат: {num1} * {num2} = {num1 * num2}");
        }
        else if (operation == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
            }
            else
            {
                Console.WriteLine($"Результат: {num1} / {num2} = {num1 / num2}");
            }
        }
        else if (operation == "%")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Ошибка: Деление на ноль невозможно.");
            }
            else
            {
                Console.WriteLine($"Результат: {num1} % {num2} = {num1 % num2}");
            }
        }
        else if (operation == "++")
        {
            num1++;
            Console.WriteLine($"Результат инкремента: {num1}");
        }
        else if (operation == "--")
        {
            num1--;
            Console.WriteLine($"Результат декремента: {num1}");
        }
        else
        {
            Console.WriteLine("Ошибка: Неверная операция.");
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
