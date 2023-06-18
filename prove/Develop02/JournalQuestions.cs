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

        public void MakeJournalEntry()
        {
            Random randomGenerator = new Random();
            int _rNumber = randomGenerator.Next(0,_journalQuestions.Length);
            string answer = "";
            

            Console.WriteLine($"{_journalQuestions[_rNumber]}");
            
            do
            {
                Console.Write("> ");
                answer = Console.ReadLine();
            } while (answer.Length <= 1);

            Entry newEntry = new Entry
            {
                    _questionNumber = _rNumber,
                    _entryResponse = answer
            };

            Program._entryList.Add(newEntry);

        }

        // Method to display Resume information
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

        public void SaveJournal()
        {
            string filename;
            Console.WriteLine("");
            Console.Write("Please enter the file name to save your journal to > ");
            filename = Console.ReadLine();

            Console.WriteLine($"Saving to journal to file {filename}");

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                int i = 1;
                foreach (Entry e in Program._entryList)
                {
                   
                    outputFile.WriteLine($"{e._dateText}/t{e._questionNumber}/t{e._entryResponse}");
                    Console.WriteLine($"Saving entry {i++}");
                }
                Console.WriteLine("Completed journal to file save");
            }

        }

        public void LoadJournal()
        {

            string filename;
            Console.WriteLine("");
            Console.Write("Please enter the file name to load your journal from > ");
            filename = Console.ReadLine();

            Console.WriteLine($"Loading journal from file {filename}");

           using (StreamReader inputFile = new StreamReader(filename))
           {
               string line;
               while ((line = inputFile.ReadLine()) != null)
               {
                   string[] fields = line.Split('\t');
                   if (fields.Length == 3)
                   {
                       string dateText = fields[0];
                       int questionNumber = int.Parse(fields[1]);
                       string entryResponse = fields[2];

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
               }
           }

            Console.WriteLine("Completed journal loading");
        }
    }
}