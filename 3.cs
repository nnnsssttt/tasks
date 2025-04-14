using System;
using System.Numerics; // Для больших чисел


public class FactorialCalculator
{
    public static BigInteger Factorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал не определен для отрицательных чисел.");
        }

        if (n == 0)
        {
            return 1; // Факториал 0 равен 1
        }

        BigInteger result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }

    public static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            try
            {
                BigInteger factorial = Factorial(number);
                Console.WriteLine($"Факториал {number} равен {factorial}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число.");
        }

    }
}
