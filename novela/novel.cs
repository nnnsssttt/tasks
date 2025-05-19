using System;

namespace SimpleNovel
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в пошаговую новеллу!");
            Console.WriteLine("Вы находитесь в лесу. Перед вами развилка.");

            Console.WriteLine("Шаг 1: Куда вы пойдете?");
            Console.WriteLine("1. Налево");
            Console.WriteLine("2. Направо");
            int choice1 = Convert.ToInt32(Console.ReadLine());

            if (choice1 == 1)
            {
                Console.WriteLine("Вы свернули налево и наткнулись на старую хижину.");
            }
            else if (choice1 == 2)
            {
                Console.WriteLine("Вы свернули направо и увидели озеро.");
            }
            else
            {
                Console.WriteLine("Вы не выбрали ни один из путей и остались на месте.");
            }

            Console.WriteLine("Шаг 2: Что вы будете делать?");
            Console.WriteLine("1. Исследовать хижину");
            Console.WriteLine("2. Купаться в озере");
            int choice2 = Convert.ToInt32(Console.ReadLine());

            if (choice2 == 1)
            {
                Console.WriteLine("Вы исследовали хижину и нашли старую карту.");
            }
            else if (choice2 == 2)
            {
                Console.WriteLine("Вы искупались в озере и почувствовали себя отдохнувшим.");
            }
            else
            {
                Console.WriteLine("Вы решили ничего не делать и просто сидеть.");
            }

            Console.WriteLine("Шаг 3: Что вы будете делать дальше?");
            Console.WriteLine("1. Изучить карту");
            Console.WriteLine("2. Продолжить путь");
            int choice3 = Convert.ToInt32(Console.ReadLine());

            if (choice3 == 1)
            {
                Console.WriteLine("Вы изучили карту и обнаружили, что она ведет к сокровищам.");
            }
            else if (choice3 == 2)
            {
                Console.WriteLine("Вы решили продолжить путь и ушли дальше в лес.");
            }
            else
            {
                Console.WriteLine("Вы решили остаться на месте и подумать.");
            }

            Console.WriteLine("Шаг 4: Что вы выберете?");
            Console.WriteLine("1. Следовать за картой");
            Console.WriteLine("2. Остаться в лесу");
            int choice4 = Convert.ToInt32(Console.ReadLine());

            if (choice4 == 1)
            {
                Console.WriteLine("Вы последовали за картой и нашли сокровища!");
            }
            else if (choice4 == 2)
            {
                Console.WriteLine("Вы остались в лесу и решили построить там дом.");
            }
            else
            {
                Console.WriteLine("Вы решили вернуться домой.");
            }

            Console.WriteLine("Шаг 5: Как вы закончите свое приключение?");
            Console.WriteLine("1. Вернуться домой с сокровищами");
            Console.WriteLine("2. Остаться в лесу и начать новую жизнь");
            int choice5 = Convert.ToInt32(Console.ReadLine());

            if (choice5 == 1)
            {
                Console.WriteLine("Вы вернулись домой с сокровищами и стали очень богатым.");
            }
            else if (choice5 == 2)
            {
                Console.WriteLine("Вы остались в лесу и начали новую жизнь, полную приключений.");
            }
            else
            {
                Console.WriteLine("Вы решили закончить свое приключение и вернуться домой.");
            }

            Console.WriteLine("Спасибо за игру!");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
