    // Journal Entry class containing the question and the answer
    public class Entry
    {
        // Define Class variable information
        // Define the date to todays date
        public string _dateText = DateTime.Now.ToShortDateString();
        // accept the question number for saving and redisplay
        public int _questionNumber;
        // used for tracking the response to the question
        public string _entryResponse;
        
        // Build constructor that is invoked using the new keyword
        public Entry()
        {
        }

        // Method to display entries information from the journal 
        // including date of entry
        // the question which was asked
        // the response to the question
        public void DisplayEntry(string[] _journalQ)
        {
            Console.WriteLine($"{_dateText} {_journalQ[_questionNumber]}");
            Console.WriteLine($"{_entryResponse}");
            Console.WriteLine("");
        }

        public void SaveEntry()
        {

        }
    }