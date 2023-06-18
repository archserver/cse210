 // Journal Entries class containing the question number and the response entry
public class JournalQuestions
{
    // Define Class variable information Fires the questions for the Journal
    public string[] _journalQuestions = {"What was your bigest accomplishment today?",
        "What could I have done better today?", 
        "Did i do any good today?", 
        "Who did I help today and how?", 
        "What were some of the things i prayed for today?", 
        "What is my next goal?", 
        "What is something I am looking forward to?",
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"};
    
    // Build constructor that is invoked using the new keyword
    public JournalQuestions()
    {
    }   
    // Ask a question get a respone and recode it to the list
     public void MakeJournalEntry()
    {
        // Builder a random number selector
        Random randomGenerator = new Random();
        int _rNumber = randomGenerator.Next(0,_journalQuestions.Length);

        string answer = "";
        // ask the selected question
        Console.WriteLine($"{_journalQuestions[_rNumber]}");
        
        do
        {
            Console.Write("> ");
            answer = Console.ReadLine();
        } while (answer.Length <= 1 );        //verify we have a response greater than 1 character


        Entry newEntry = new Entry
        {
                _questionNumber = _rNumber,
                _entryResponse = answer
        };        

        // add the date question id and response to the list
        Program._entryList.Add(newEntry);    
    }    
        
    // Method to display Journal information
    public void DisplayJournal()
    {
        
        Console.WriteLine($"Your Current Journal Records:");
        // travers the list calling the displayentry from the Entry class
        foreach (Entry e in Program._entryList)
        {
            e.DisplayEntry(_journalQuestions);
        }
        Console.WriteLine("");
    }   

    // save the Journal to a text file
    public void SaveJournal()
    {
        // define the file name
        string filename;
        // skip a space so it is readable
        Console.WriteLine("");
        Console.Write("Please enter the file name to save your journal to > ");
        filename = Console.ReadLine();        

        Console.WriteLine($"Saving to journal to file {filename}");        
        // open the file
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            int i = 1;
            // step through the journal entries
            foreach (Entry e in Program._entryList)
            {
                // prep the code for a " in the text
                string CSVformatDate = e._dateText.Replace("\"", "\"\"");
                string CSVformatResponse = e._entryResponse.Replace("\"", "\"\"");

                outputFile.WriteLine($"\"{CSVformatDate}\",\"{e._questionNumber}\",\"{CSVformatResponse}\"");
                Console.WriteLine($"Saving entry {i++}");
            }
            Console.WriteLine("Completed journal to file save");
        }    
    }    
    
    // Load the Journal from a text file
    public void LoadJournal()
    {  
       string filename;
       Console.WriteLine("");
       Console.Write("Please enter the file name to load your journal from > ");
       filename = Console.ReadLine();
       Console.WriteLine($"Loading journal from file {filename}");      
       using (StreamReader inputFile = new StreamReader(filename))
       {
        // read the file until there is nothing left
           while (!inputFile.EndOfStream)
           {
               string record = inputFile.ReadLine();
               string[] eachcolumn = record.Split(',');
               if (eachcolumn.Length == 3)
               {
                    // remove extra "
                    string dateText = eachcolumn[0].Trim('"');
                    int questionNumber;
                    if (int.TryParse(eachcolumn[1], out questionNumber))
                    {
                        // remove extra "
                        string entryResponse = eachcolumn[2].Trim('"');

                        // Create a new Entry record and load the necessary fields
                        Entry entry = new Entry
                        {
                            _dateText = dateText,
                            _questionNumber = questionNumber,
                            _entryResponse = entryResponse
                        };

                        // Add the entry to the global entrylist
                        Program._entryList.Add(entry);

                    }
                };                   
              
            }
        }
        Console.WriteLine("Completed journal loading");
    }        
}

