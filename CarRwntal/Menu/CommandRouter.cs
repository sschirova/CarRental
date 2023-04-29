using CarRwntal.Menu.Commands;

namespace CarRwntal.Menu;

public class CommandRouter
{
    public static void ChooseCommand(int CommandID)
    {
        Console.Clear();
        switch (CommandID)
        {
            case 1:
                RegistrationNEW.Execute();
                break;
            case 2:
                Withdrawal.Execute();
                break;
            case 3:
                Registered.Execute();
                break;
            case 4:
                CleaningCust.Execute();
                break;
            case 5:
                SearchCust.Execute();
                break;
           
              
        }
    }
}