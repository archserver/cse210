using System;

public enum GoalType
{
    Simple,
    Eternal,
    Checklist,
    Milestone
}



class Program
{
    static void Main(string[] args)
    {
        // Define Variables
        GoalManager manager = new GoalManager();

        // enter user ID for loading a goal File remove excess spaces
        manager.EnterUserID();
        // check for a load file with extension of {userID}.goal, if exist Load if not go to creating goals
        manager.DisplayMenu();
        Console.WriteLine("Finishing Eternal Quest");
    }

}

public class StringUtility
{
    public static readonly string Pattern = @"[^a-zA-Z0-9\s]";
}