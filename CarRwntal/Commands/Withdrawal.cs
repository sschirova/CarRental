namespace CarRwntal.Menu.Commands;

public abstract class Withdrawal
{
    public static void Execute()
    {
        Console.Clear();
        Console.WriteLine("*          Снятие с обслуживания клиента           *");
        Console.WriteLine("|--------------------------------------------------|");
        Console.WriteLine("| ФИО               |                               |");
        Console.WriteLine("| Паспортные данные |                               |");
        Console.WriteLine("| Адрес проживания  |                               |");
        Console.WriteLine("| Номер ВУ          |                               |");
        Console.WriteLine("|--------------------------------------------------|");
        Console.CursorVisible = true;
    }

}