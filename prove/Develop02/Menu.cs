public class Menu
{
    private string[] _menuDesc;
    private Action[] _menuExec;

    public Menu(string[] MenuDescription, Action[] ExecuteCommand)
    {
            _menuDesc = MenuDescription;
            _menuExec = ExecuteCommand;
    }

    public bool DisplayMenu()
    {
        bool rtvalue = true;
        string command;

        for (int m = 0 ; m < _menuDesc.Length ; m++)
        {
            Console.WriteLine($"{m + 1} {_menuDesc[m]}");
        }
        Console.Write(">");
        command = Console.ReadLine();

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