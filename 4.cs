using System;
using System.Collections.Generic;
using System.Linq;

public class MaxElementFinder
{
    public static int FindMax(List<int> numbers)
    {
        if (numbers == null || numbers.Count == 0)
        {
            throw new ArgumentException("Список не может быть пустым или null.");
        }

        return numbers.Max(); // Используем LINQ для простоты
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел:");
        string input = Console.ReadLine();

        List<int> numbers = new List<int>();
        string[] numberStrings = input.Split(' ');

        foreach (string numberString in numberStrings)
        {
            if (int.TryParse(numberString, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine($"Ошибка: '{numberString}' не является числом. Оно будет пропущено.");
            }
        }


        if (numbers.Count > 0)
        {
            try
            {
                int max = FindMax(numbers);
                Console.WriteLine($"Максимальный элемент: {max}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Вы не ввели ни одного числа.");
        }


    }
}