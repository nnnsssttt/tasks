using System;

public class TextAdventure
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Затерянный в лесу");

        
        Console.WriteLine("Ты просыпаешься в лесу. Что будешь делать?");
        Console.WriteLine("a) Пойдешь на север (компас)");
        Console.WriteLine("b) Пойдешь на запад (закат)");
        Console.WriteLine("c) Заберешься на дерево");

        char choice1 = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (choice1)
        {
            case 'a':
                
                Console.WriteLine("Ты нашел тропинку. Что дальше?");
                Console.WriteLine("a) Идти по тропинке");
                Console.WriteLine("b) Свернуть в лес");

                char choice2a = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice2a == 'a')
                {
                    
                    Console.WriteLine("Ты нашел хижину. Постучишь? (да/нет)");
                    string choice3aa = Console.ReadLine().ToLower();
                    if (choice3aa == "да")
                    {
                        Console.WriteLine("Тебя встретил дружелюбный отшельник и показал дорогу."); 
                    }
                    else
                    {
                        Console.WriteLine("Ты ушел от хижины и заблудился."); 
                    }
                }
                else if (choice2a == 'b')
                {
                    
                    Console.WriteLine("Ты нашел светящийся цветок. Прикоснёшься? (да/нет)");
                    string choice3ab = Console.ReadLine().ToLower();
                    if (choice3ab == "да")
                    {
                        Console.WriteLine("Цветок оказался магическим и перенес тебя домой!"); 
                    }
                    else
                    {
                        Console.WriteLine("Ты прошел мимо цветка и заблудился."); 
                    }
                }
                break;


            case 'b':
               
                Console.WriteLine("Ты в болоте. Что делать?");
                Console.WriteLine("a) Выбраться самому");
                Console.WriteLine("b) Позвать на помощь");
                
                break;

            case 'c':
               
                Console.WriteLine("Ты на дереве. Видишь дым. Что делать?");
                Console.WriteLine("a) Идти к дыму");
                Console.WriteLine("b) Остаться на дереве");
               
                break;

            default:
                Console.WriteLine("Неверный выбор.");
                break;
        }


        Console.ReadKey(); 
    }
}