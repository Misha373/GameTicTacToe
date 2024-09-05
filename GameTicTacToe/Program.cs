Console.OutputEncoding = System.Text.Encoding.UTF8;
char cell1 = '1';
char cell2 = '2';
char cell3 = '3';
char cell4 = '4';
char cell5 = '5';
char cell6 = '6';
char cell7 = '7';
char cell8 = '8';
char cell9 = '9';
bool GameWon = false;
int MoveCounter = 0;
char CurrentPlayer = 'X';


while (MoveCounter < 9 && !GameWon)
{
    Console.Clear();
    Console.WriteLine($" {cell1} | {cell2} | {cell3} ");
    Console.WriteLine("---|---|---");
    Console.WriteLine($" {cell4} | {cell5} | {cell6} ");
    Console.WriteLine("---|---|---");
    Console.WriteLine($" {cell7} | {cell8} | {cell9} ");
    Console.Write($"Введіть хід гравці {CurrentPlayer}, число від 1 до 9: ");


    try {
        int choice = int.Parse(Console.ReadLine());
        bool validMove = false;
        if (choice == 1 && cell1 == '1') { cell1 = CurrentPlayer; validMove = true; }
        else if (choice == 2 && cell2 == '2') { cell2 = CurrentPlayer; validMove = true; }
        else if (choice == 3 && cell3 == '3') { cell3 = CurrentPlayer; validMove = true; }
        else if (choice == 4 && cell4 == '4') { cell4 = CurrentPlayer; validMove = true; }
        else if (choice == 5 && cell5 == '5') { cell5 = CurrentPlayer; validMove = true; }
        else if (choice == 6 && cell6 == '6') { cell6 = CurrentPlayer; validMove = true; }
        else if (choice == 7 && cell7 == '7') { cell7 = CurrentPlayer; validMove = true; }
        else if (choice == 8 && cell8 == '8') { cell8 = CurrentPlayer; validMove = true; }
        else if (choice == 9 && cell9 == '9') { cell9 = CurrentPlayer; validMove = true; }

        if (validMove)
        {
            MoveCounter++;
            if (cell1 == CurrentPlayer && cell2 == CurrentPlayer && cell3 == CurrentPlayer ||
                cell4 == CurrentPlayer && cell5 == CurrentPlayer && cell6 == CurrentPlayer ||
                cell7 == CurrentPlayer && cell8 == CurrentPlayer && cell9 == CurrentPlayer ||
                cell1 == CurrentPlayer && cell4 == CurrentPlayer && cell7 == CurrentPlayer ||
                cell2 == CurrentPlayer && cell5 == CurrentPlayer && cell8 == CurrentPlayer ||
                cell3 == CurrentPlayer && cell6 == CurrentPlayer && cell9 == CurrentPlayer ||
                cell1 == CurrentPlayer && cell5 == CurrentPlayer && cell9 == CurrentPlayer ||
                cell3 == CurrentPlayer && cell5 == CurrentPlayer && cell7 == CurrentPlayer)
            {
                GameWon = true;
                Console.Clear();
                Console.WriteLine($" {cell1} | {cell2} | {cell3} ");
                Console.WriteLine("---|---|---");
                Console.WriteLine($" {cell4} | {cell5} | {cell6} ");
                Console.WriteLine("---|---|---");
                Console.WriteLine($" {cell7} | {cell8} | {cell9} ");
                Console.WriteLine($"Переміг гравець- {CurrentPlayer}!");

            }
            else if (MoveCounter == 9)
            {
                Console.Clear();
                Console.WriteLine($" {cell1} | {cell2} | {cell3} ");
                Console.WriteLine("---|---|---");
                Console.WriteLine($" {cell4} | {cell5} | {cell6} ");
                Console.WriteLine("---|---|---");
                Console.WriteLine($" {cell7} | {cell8} | {cell9} ");
                Console.WriteLine("Нічия!");
            }
            else
            {
                if (CurrentPlayer == 'X')
                {
                    CurrentPlayer = 'O';
                }
                else
                {
                    CurrentPlayer = 'X';
                }
            }

        }
        else
        {
            Console.WriteLine("Клітинка вже зайнята або введено невірний номер. Спробуйте ще раз.");
        }


    }
    catch
    {
        Console.WriteLine("Будь ласка, введіть число від 1 до 9.");
    }
}