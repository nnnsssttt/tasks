using System;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите сумму вклада: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Введите количество месяцев: ");
            int months = Convert.ToInt32(Console.ReadLine());

            int monthCounter = 0;
            while (monthCounter < months)
            {
                sum *= 1.07m;
                monthCounter++;
            }

            Console.WriteLine($"Конечная сумма вклада после {months} месяцев: {sum}");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
