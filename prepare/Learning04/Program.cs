using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment as1 = new Assignment("Jane Doe", "New Devision");
        Console.WriteLine(as1.GetSummary());

        MathAssignment as2 = new MathAssignment("Pi Piper", "Multiply and Replenish", "Rooting", "Define the Root of a Number");
        Console.WriteLine(as2.GetSummary());
        Console.WriteLine(as2.GetHomeworkList());

        WritingAssignment as3 = new WritingAssignment("Stephen Hawkings", "A tale of time", "Space and Time");
        Console.WriteLine(as3.GetSummary());
        Console.WriteLine(as3.GetWritingInfo());


    }
}