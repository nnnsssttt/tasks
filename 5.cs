using System;
using System.Collections.Generic;
using System.Linq;

public class DuplicateRemover
{
    public static List<int> RemoveDuplicates(List<int> numbers)
    {
        return new List<int>(new HashSet<int>(numbers)); // Используем HashSet для эффективности
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
            List<int> uniqueNumbers = RemoveDuplicates(numbers);

            Console.WriteLine("Список без дубликатов:");
            foreach (int number in uniqueNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

        }
        else
        {
            Console.WriteLine("Вы не ввели ни одного числа.");
        }
    }
}