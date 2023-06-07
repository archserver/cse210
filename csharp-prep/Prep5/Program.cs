using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        string User_Name = PromptUserName();
        int thenumber = PromptUserNumber();
        int sq = SquareNumber(thenumber);
        DisplayResult(User_Name, sq);
        
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string answer = Console.ReadLine();
        int anumber = int.Parse(answer);
        return anumber;
    }
    
    static int SquareNumber(int bnumber)
    {
        bnumber *= bnumber;
        return bnumber;
    }

    static void DisplayResult(string aname, int cnumber)
    {
        Console.WriteLine($"{aname}, the square of your number is {cnumber}");
    }
}