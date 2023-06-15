using System;

class Program
{
    static void Main(string[] args)
    {
       // define variables or create class variables
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume = new Resume();

        job1._companyName = "OCI";
        job1._jobTitle = "Infrastructure Director";
        job1._startYear = 2014;
        job1._endYear= 2023;

        job2._companyName = "Active Organics";
        job2._jobTitle = "IT Director";
        job2._startYear = 1999;
        job2._endYear = 2014;

        resume._Name = "Bryon Chase";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.ShowResume();

    }
}