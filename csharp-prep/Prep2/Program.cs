using System;

class Program
{
    
    static void Main(string[] args)
    {
        // Define Variables
        string stringvalue = "", grade = "";
        int value = -1, remainder = 0;
        bool passing = false;

        while (value < 0 || value > 100)
        {
          Console.Write("Please enter your percentage grade. ");
          stringvalue = Console.ReadLine();
          value = int.Parse(stringvalue);
        }

        if(value >= 70)
        {
          passing = true;
        }
        remainder = value % 10;

        if (value >= 90)
        {
            if (value >=93)
            {
               grade = "A";
            }
            else
            {
               grade = "A-";
            }
        }
        else if (value >= 80)
        {
            if (remainder >= 7)
            {
              grade = "B+";
            }
            else if (remainder >= 3)
            {
              grade = "B";
            }
            else
            {
              grade = "B-";
            }
        }
        else if (value >= 70)
        {
            if (remainder >= 7)
            {
              grade = "C+";
            }
            else if (remainder >= 3)
            {
              grade = "C";
            }
            else
            {
              grade = "C-";
            }
        }
        else if (value >= 60)
        {
            if (remainder >= 7)
            {
              grade = "D+";
            }
            else if (remainder >= 3)
            {
              grade = "D";
            }
            else
            {
              grade = "D-";
            }
        }
        else 
        {
            grade = "F";
        }

        Console.WriteLine($"Course Grade: {grade}");

        if (passing)
        {
            Console.WriteLine("Congradulations on passing the course.");
        }
        else
        {
            Console.WriteLine("Unfortuniatly you did not receive a passing grade, you can do better next time.");
        }
    }   
}