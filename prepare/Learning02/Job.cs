    // Job Class listing information including Company Name, Job Title, start year and end year with a method to print the stored information
    public class Job
    {
        // Define Class variable information
        public string _companyName;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        // Build constructor that is invoked using the new keyword
        public Job()
        {
        }

        // Method to display job information
        public void ShowJob()
        {
            Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
        }
    }