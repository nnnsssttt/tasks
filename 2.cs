using System;
using System.Linq;

public class PalindromeChecker
{
    public static bool IsPalindrome(string text)
    {
        // Удаляем пробелы и приводим к нижнему регистру
        string cleanText = new string(text.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();

        // Переворачиваем строку
        string reversedText = new string(cleanText.ToCharArray().Reverse().ToArray());

        return cleanText == reversedText;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите текст для проверки:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("Это палиндром.");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }
}