using System;

class Program
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X';

    static void Main()
    {
        bool gameOver = false;

        while (!gameOver)
        {
            Console.Clear();
            ShowBoard();
            Console.WriteLine("Игрок " + currentPlayer + ", выбери ячейку (1-9):");
            string input = Console.ReadLine();

            int position;
            if (int.TryParse(input, out position) && position >= 1 && position <= 9)
            {
                if (board[position - 1] != 'X' && board[position - 1] != 'O')
                {
                    board[position - 1] = currentPlayer;

                    if (CheckWin())
                    {
                        Console.Clear();
                        ShowBoard();
                        Console.WriteLine("Игрок " + currentPlayer + " победил!");
                        gameOver = true;
                    }
                    else if (CheckDraw())
                    {
                        Console.Clear();
                        ShowBoard();
                        Console.WriteLine("Ничья!");
                        gameOver = true;
                    }
                    else
                    {
                        if (currentPlayer == 'X')
                            currentPlayer = 'O';
                        else
                            currentPlayer = 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Эта ячейка уже занята. Нажми любую клавишу и попробуй снова.");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Нажми любую клавишу и попробуй снова.");
                Console.ReadKey();
            }
        }

        Console.WriteLine("Игра окончена. Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }

    static void ShowBoard()
    {
        Console.WriteLine();
        Console.WriteLine(" " + board[0] + " | " + board[1] + " | " + board[2]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" " + board[3] + " | " + board[4] + " | " + board[5]);
        Console.WriteLine("---+---+---");
        Console.WriteLine(" " + board[6] + " | " + board[7] + " | " + board[8]);
        Console.WriteLine();
    }

    static bool CheckWin()
    {
        if (board[0] == currentPlayer && board[1] == currentPlayer && board[2] == currentPlayer) return true;
        if (board[3] == currentPlayer && board[4] == currentPlayer && board[5] == currentPlayer) return true;
        if (board[6] == currentPlayer && board[7] == currentPlayer && board[8] == currentPlayer) return true;

        if (board[0] == currentPlayer && board[3] == currentPlayer && board[6] == currentPlayer) return true;
        if (board[1] == currentPlayer && board[4] == currentPlayer && board[7] == currentPlayer) return true;
        if (board[2] == currentPlayer && board[5] == currentPlayer && board[8] == currentPlayer) return true;

        if (board[0] == currentPlayer && board[4] == currentPlayer && board[8] == currentPlayer) return true;
        if (board[2] == currentPlayer && board[4] == currentPlayer && board[6] == currentPlayer) return true;

        return false;
    }

    static bool CheckDraw()
    {
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i] != 'X' && board[i] != 'O')
                return false;
        }
        return true;
    }
}