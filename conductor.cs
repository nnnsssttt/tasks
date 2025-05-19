using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Консольный файловый проводник");
        Console.WriteLine();

        string currentPath = Directory.GetCurrentDirectory();

        while (true)
        {
            Console.WriteLine("Текущая папка: " + currentPath);
            ShowDirectoryContents(currentPath);

            Console.WriteLine();
            Console.WriteLine("Команды:");
            Console.WriteLine("1 - Перейти в папку");
            Console.WriteLine("2 - Назад");
            Console.WriteLine("3 - Открыть файл");
            Console.WriteLine("4 - Создать папку");
            Console.WriteLine("5 - Создать файл");
            Console.WriteLine("6 - Удалить");
            Console.WriteLine("0 - Выход");
            Console.Write("Введите номер команды: ");
            string choice = Console.ReadLine();

            if (choice == "0")
                break;
            else if (choice == "1")
            {
                Console.Write("Введите имя папки: ");
                string folderName = Console.ReadLine();
                string newPath = Path.Combine(currentPath, folderName);
                if (Directory.Exists(newPath))
                {
                    currentPath = newPath;
                }
                else
                {
                    Console.WriteLine("Папка не найдена.");
                }
            }
            else if (choice == "2")
            {
                DirectoryInfo parent = Directory.GetParent(currentPath);
                if (parent != null)
                    currentPath = parent.FullName;
                else
                    Console.WriteLine("Вы уже в корневой папке.");
            }
            else if (choice == "3")
            {
                Console.Write("Введите имя файла: ");
                string fileName = Console.ReadLine();
                string filePath = Path.Combine(currentPath, fileName);
                if (File.Exists(filePath))
                {
                    Console.WriteLine("Содержимое файла:");
                    Console.WriteLine(File.ReadAllText(filePath));
                }
                else
                {
                    Console.WriteLine("Файл не найден.");
                }
            }
            else if (choice == "4")
            {
                Console.Write("Введите имя новой папки: ");
                string newFolder = Console.ReadLine();
                Directory.CreateDirectory(Path.Combine(currentPath, newFolder));
                Console.WriteLine("Папка создана.");
            }
            else if (choice == "5")
            {
                Console.Write("Введите имя файла: ");
                string newFile = Console.ReadLine();
                Console.Write("Введите текст: ");
                string text = Console.ReadLine();
                File.WriteAllText(Path.Combine(currentPath, newFile), text);
                Console.WriteLine("Файл создан.");
            }
            else if (choice == "6")
            {
                Console.Write("Введите имя файла или папки для удаления: ");
                string name = Console.ReadLine();
                string target = Path.Combine(currentPath, name);

                if (File.Exists(target))
                {
                    File.Delete(target);
                    Console.WriteLine("Файл удалён.");
                }
                else if (Directory.Exists(target))
                {
                    Directory.Delete(target, true);
                    Console.WriteLine("Папка удалена.");
                }
                else
                {
                    Console.WriteLine("Не найдено.");
                }
            }

            Console.WriteLine("Нажмите Enter, чтобы продолжить...");
            Console.ReadLine();
            Console.Clear();
        }

        Console.
            WriteLine("Выход из программы.");
    }

    static void ShowDirectoryContents(string path)
    {
        Console.WriteLine("Папки:");
        foreach (string dir in Directory.GetDirectories(path))
        {
            Console.WriteLine("  [DIR] " + Path.GetFileName(dir));
        }

        Console.WriteLine("Файлы:");
        foreach (string file in Directory.GetFiles(path))
        {
            Console.WriteLine("       " + Path.GetFileName(file));
        }
    }
}