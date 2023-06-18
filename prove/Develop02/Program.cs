using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare Variables
        string[] menuDesc = {"Write a note in your journal","Display your Journal","Load an existing Journal","Save your current Journal","Exit"};
        Action[] menuExec = {Requestinput, DisplayJournal, LoadContent, SaveContent};
        Menu menu = new Menu(menuDesc, menuExec);
        bool KeepRunning = true;
        

        do
        {
            
            KeepRunning = menu.DisplayMenu();

        } while (KeepRunning);
        
    }

    static void Requestinput()
    {
        Console.WriteLine("Executing Requestinput");
    }

    static void DisplayJournal()
    {
        Console.WriteLine("Executing DisplayJournal");
    }

    static void LoadContent()
    {
        Console.WriteLine("Executing LoadContent");
    }

    static void SaveContent()
    {
        Console.WriteLine("Executing SaveContent");
    }
}


