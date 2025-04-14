using System;
using System.Collections.Generic;
using System.Linq;

public class SumCalculator
{
    public static int Sum(List<int> numbers) => numbers.Sum();

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();

        // Разбиваем строку на массив строк, используя пробел как разделитель
        string[] numberStrings = input.Split(' ');

        // Преобразуем массив строк в список чисел
        List<int> numbers = new List<int>();
        foreach (string numberString in numberStrings)
        {
            if (int.TryParse(numberString, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"Ошибка: '{numberString}' не является числом.");
            }
        }


        if (numbers.Count > 0)
        {
            int sum = Sum(numbers);
            Console.WriteLine($"Сумма: {sum}");
        }
        else
        {
            Console.WriteLine($"Список чисел пуст.");
        }

    }
}