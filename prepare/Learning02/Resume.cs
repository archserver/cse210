    // Resume class containing the name of the individual alomg with multiple job listings for the individual
    public class Resume
    {
        // Define Class variable information
        public string _Name;
        public List<Job> _jobs = new List<Job>();
        
        // Build constructor that is invoked using the new keyword
        public Resume()
        {
        }

        // Method to display Resume information
        public void ShowResume()
        {
            Console.WriteLine($"Name: {_Name} ");
            Console.WriteLine("Jobs:");
            // list each job for the individuals resume
            foreach (Job j in _jobs)
            {
                j.ShowJob();
            }
        }
    }