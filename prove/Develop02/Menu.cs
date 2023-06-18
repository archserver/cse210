public class Menu
{
    private string[] _menuDesc;
    private Action[] _menuExec;

// build the menue with the avaliable commnds and commands to execute
    public Menu(string[] MenuDescription, Action[] ExecuteCommand)
    {
        _menuDesc = MenuDescription;
        _menuExec = ExecuteCommand;
    }

    public bool DisplayMenu()
    {
        // rtvalue dtermins if we are exiting the program or not
        bool rtvalue = true;
        // the command number we are running 
        string command;

        for (int m = 0 ; m < _menuDesc.Length ; m++)
        {
            Console.WriteLine($"{m + 1} {_menuDesc[m]}");
        }
        Console.Write("Enter the number next to the option you would like to do ");
        command = Console.ReadLine();

// validate the command is a valid selection
        if ("12345".Contains(command) && command.Length == 1)
        {
            if (command == "5")
            {
                rtvalue = false;
            }
            else
            {
                int value = int.Parse(command);

                Action selectedAction = _menuExec[value - 1];
                selectedAction.Invoke();
            }
        }

        return rtvalue;
    }
}