using System;

class Program
{
    static void Main(string[] args)
    {
        // Define Variables
        int mnumber, guess;
        string answer;

        // build a random number generator
        Random randomGenerator = new Random();

        do
        {
            guess = -1;
            
            mnumber = randomGenerator.Next(1,100);

            while (guess == -1 || guess != mnumber)
            {
                answer = "";
                while (answer == "")
                {
                    Console.Write("What is your guess? ");
                    answer = Console.ReadLine();
                }
                guess = int.Parse(answer);

                if (guess < mnumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > mnumber)
                {
                    Console.WriteLine("Lower");
                }
            }
            
            Console.WriteLine("You guessed it!");

            Console.Write("Would you like to play again? ");
            answer = Console.ReadLine();

        } while (answer == "Yes");

    }
}