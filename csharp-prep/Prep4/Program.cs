using System;

class Program
{
    static void Main(string[] args)
    {

        // Define Variables
        string answer;
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");


        do
        {

            Console.Write("Enter a number: ");
            answer = Console.ReadLine();
            if (answer != "0")
            {
                numbers.Add (int.Parse(answer));
            }
        } while (answer != "0");

        int min = numbers.AsQueryable().Min();
        int max = numbers.AsQueryable().Max();
        int total = numbers.Sum();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {total/ numbers.Count}");
        Console.WriteLine($"The largest number is: {max}");
    }
}