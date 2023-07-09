using System;
using System.Text.RegularExpressions;

public class Goal
{
    // set Variables for the Goal Class
    protected GoalType _type;
    protected GoalManager Manager;
    private string _goalTitle;
    private string _goalDescription;
    private int _goalValue;
            
    public Goal(GoalManager manager)
    {
        Manager = manager;
    }

    public GoalType Type
    {
        get{return _type;}
        set{_type = value;}
    }

   public virtual bool GetCompleted()
   {
        return true;
   }

   public virtual void FillInInfo()
    {
        // Enter information for Simple
        EnterTitle();
        EnterDescription();
        EnterValue();
    }

    public void EnterTitle()
    {
        Console.Write("Enter the Name of the Goal: ");
        string g = Regex.Replace(Console.ReadLine(), StringUtility.Pattern,"");
        SetTitle(g);
        return;
    }

    public void EnterDescription()
    {
        Console.Write("Enter the Description of the Goal: ");
        string g = Regex.Replace(Console.ReadLine(), StringUtility.Pattern,"");
        SetDescription(g);
        return;
    }

    public virtual void EnterValue()
    {
        bool canexit = false;
        int value;

        do
        {
          Console.Write("Enter the Value in Points of the Goal between 10 and 1000: ");
          string result = Console.ReadLine();
          if (int.TryParse(result, out value))
          {
            if (value >= 10 && value <=1000)
            {
                canexit = true;
            }
          }

        } while (!canexit);
        SetValue(value);
    }

    public void SetTitle(string s)
    {
        _goalTitle = s;
    }

    public string GetTitle()
    {
        return _goalTitle; 
    }

    public void SetDescription(string d)
    {
        _goalDescription = d;
    }

    public string GetDescription()
    {
        return _goalDescription;
    }

    public void SetValue(int v)
    {
        _goalValue = v;
    }

    public int GetValue()
    {
        return _goalValue;
    }

    public virtual void DisplayGoal()
    {
        Console.WriteLine($"Goal: {_goalTitle} Value: {_goalValue}");
    }
    
    public virtual void FinishGoal()
    {
        Console.WriteLine($"Congradulations on completing: {GetTitle()}");
        Manager.SetScore(Manager.GetScore() + GetValue());
    }
    
    public virtual void RecordEvent()
    {
        Console.WriteLine("Recording an event for the goal");
    }
}