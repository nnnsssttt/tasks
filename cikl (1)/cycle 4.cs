using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            bool validInput = false;
            int num1 = 0, num2 = 0;

            for (; !validInput;)
            {
                Console.Write("Введите первое число (0-10): ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число (0-10): ");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num1 >= 0 && num1 <= 10 && num2 >= 0 && num2 <= 10)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Введенные числа недопустимы. Пожалуйста, введите числа от 0 до 10.");
                }
            }

            Console.WriteLine($"Результат умножения: {num1 * num2}");
            Console.ReadKey();
        }
    }
}
