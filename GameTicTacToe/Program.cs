Console.WriteLine("HW 7.1. Гра Хрестики-нолики.");

class TicTacToe
{
    static char cell1 = '1', cell2 = '2', cell3 = '3';
    static char cell4 = '4', cell5 = '5', cell6 = '6';
    static char cell7 = '7', cell8 = '8', cell9 = '9';
    static char currentPlayer = 'X';

    static void Main()
    {
        int moveCounter = 0;
        bool gameWon = false;

        while (moveCounter < 9 && !gameWon)
        {
            Console.Clear();
            PrintBoard();
            Console.WriteLine($"Хід гравця {currentPlayer}. Виберіть клітинку (1-9): ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (MakeMove(choice))
                {
                    moveCounter++;
                    gameWon = CheckWin();
                    if (gameWon)
                    {
                        Console.Clear();
                        PrintBoard();
                        Console.WriteLine($"Переміг гравець {currentPlayer}!");
                    }
                    else if (moveCounter == 9)
                    {
                        Console.Clear();
                        PrintBoard();
                        Console.WriteLine("Нічия!");
                    }
                    else
                    {
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                    }
                }
                else
                {
                    Console.WriteLine("Клітинка вже зайнята або введено невірний номер. Спробуйте ще раз.");
                }
            }
            else
            {
                Console.WriteLine("Будь ласка, введіть число від 1 до 9.");
            }
        }
    }

    static void PrintBoard()
    {
        Console.WriteLine($" {cell1} | {cell2} | {cell3} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {cell4} | {cell5} | {cell6} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {cell7} | {cell8} | {cell9} ");
    }

    static bool MakeMove(int choice)
    {
        switch (choice)
        {
            case 1: if (cell1 == '1') { cell1 = currentPlayer; return true; } break;
            case 2: if (cell2 == '2') { cell2 = currentPlayer; return true; } break;
            case 3: if (cell3 == '3') { cell3 = currentPlayer; return true; } break;
            case 4: if (cell4 == '4') { cell4 = currentPlayer; return true; } break;
            case 5: if (cell5 == '5') { cell5 = currentPlayer; return true; } break;
            case 6: if (cell6 == '6') { cell6 = currentPlayer; return true; } break;
            case 7: if (cell7 == '7') { cell7 = currentPlayer; return true; } break;
            case 8: if (cell8 == '8') { cell8 = currentPlayer; return true; } break;
            case 9: if (cell9 == '9') { cell9 = currentPlayer; return true; } break;
        }
        return false;
    }

    static bool CheckWin()
    {
        // Перевірка рядків
        if (cell1 == currentPlayer && cell2 == currentPlayer && cell3 == currentPlayer) return true;
        if (cell4 == currentPlayer && cell5 == currentPlayer && cell6 == currentPlayer) return true;
        if (cell7 == currentPlayer && cell8 == currentPlayer && cell9 == currentPlayer) return true;

        // Перевірка стовпців
        if (cell1 == currentPlayer && cell4 == currentPlayer && cell7 == currentPlayer) return true;
        if (cell2 == currentPlayer && cell5 == currentPlayer && cell8 == currentPlayer) return true;
        if (cell3 == currentPlayer && cell6 == currentPlayer && cell9 == currentPlayer) return true;

        // Перевірка діагоналей
        if (cell1 == currentPlayer && cell5 == currentPlayer && cell9 == currentPlayer) return true;
        if (cell3 == currentPlayer && cell5 == currentPlayer && cell7 == currentPlayer) return true;

        return false;
    }
}
