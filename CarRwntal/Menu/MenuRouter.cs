namespace CarRwntal.Menu;

public class MenuRouter
{
    public static void Initialise()
    {
        int cursorPosition = 1;
        while (true)
        {
            Console.CursorVisible = false;
            Console.Clear();
            PrintMenuTable(cursorPosition);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow: //up in menu
                    if (cursorPosition > 1) cursorPosition = cursorPosition - 1;
                    break;
                case ConsoleKey.DownArrow: //down in menu
                    if (cursorPosition < 5) cursorPosition = cursorPosition + 1;
                    break;
                case ConsoleKey.Enter: //execute
                    CommandRouter.ChooseCommand(cursorPosition);
                    break;
            }
        }
    }

    public static void PrintMenuTable(int CursorPosition)
    {
        Console.SetCursorPosition(0,0);
        Console.WriteLine("*--------------------------------------------------*");
        Console.WriteLine("| | Регистрация новго клиента                      |");
        Console.WriteLine("| | Снятие с обслуживания клиента                  |");
        Console.WriteLine("| | Просмотр всех зарегистрированных клиентов      |");
        Console.WriteLine("| | Очистка данных о клиентах                      |");
        Console.WriteLine("| | Поиск клиента                                  |");
        Console.WriteLine("*--------------------------------------------------*");
        Console.SetCursorPosition(1,CursorPosition);
        Console.Write('*');
    }
}