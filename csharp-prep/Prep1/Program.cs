using System;


class Program
{

    static void Main(string[] args)
    {
        // Define Variables
        string FName = "", LName = "";

        
        while (FName.Length < 2)
        {
            Console.Write("What is your first name? ");
            FName = Console.ReadLine();
        }

        while (LName.Length < 2)
        {
            Console.Write("What is your last name? ");
            LName = Console.ReadLine();
        }

        Console.WriteLine($"Your name is {LName}, {FName} {LName}");

    }
}