using System;

class Program
{
    // Define the public list for Journal Entries by calling the Entrys Class
    public static List<Entry> _entryList = new List<Entry>();

    static void Main(string[] args)
    {
        // Declare Variables
        // Build the tiein for the Methods in the JournalQuestions 
        JournalQuestions journal = new JournalQuestions();
        // Build an array for the Menu and an execution of the code from the selection
        string[] menuDesc = {
            "Write a note in your journal",
            "Display your Journal",
            "Load an existing Journal",
            "Save your current Journal",
            "Exit"};
        Action[] menuExec = {journal.MakeJournalEntry, 
            journal.DisplayJournal, 
            journal.LoadJournal, 
            journal.SaveJournal};
        // Load the Menue Class
        Menu menu = new Menu(menuDesc, menuExec);
        // to terminate the run of the code if Exit is selected
        bool KeepRunning = true;

        do
        {
            
            KeepRunning = menu.DisplayMenu();

        } while (KeepRunning);
        
    }
}
