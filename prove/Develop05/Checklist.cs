public class CheckListGoal: Goal
{
    private int _maxToComplete, _numberCompleted, _valueEach;

    public CheckListGoal(GoalManager manager) : base(manager) 
    {
        Type = GoalType.Checklist;
    }

    public override bool GetCompleted()
    {
        if (_maxToComplete == _numberCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public void SetTimesCompleted(int b)
    {
        _numberCompleted = b;
    }

    public int GetTimesCompleted()
    {
        return _numberCompleted;
    }
    
    public void SetMax(int m)
    {
        _maxToComplete = m;
    }

    public int GetMax()
    {
        return _maxToComplete;
    }

    public void SetEachValue(int e)
    {
        _valueEach = e;
    }

    public int GetEachValue()
    {
        return _valueEach;
    }

    public override void FillInInfo()
    {
        // Enter information for Milestone Goal
        EnterTitle();
        EnterDescription();
        EnterValue();
        EnterMax();
        EnterEach();
    }

    public override void EnterValue()
    {
        bool canexit = false;
        int value;

        do
        {
          Console.Write("Enter the Bonus Value in points when goal is completed between 10 and 1000: ");
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

    public void EnterEach()
    {
        bool canexit = false;
        int value;

        do
        {
          Console.Write("Enter the value in points for each time the goal done between 10 and 1000: ");
          string result = Console.ReadLine();
          if (int.TryParse(result, out value))
          {
            if (value >= 10 && value <=1000)
            {
                canexit = true;
            }
          }

        } while (!canexit);
        SetEachValue(value);
    }


    public void EnterMax()
    {
        bool canexit = false;
        int value;

        do
        {
            Console.Write("How many times can this be completed between 2 and 100? ");
            string result = Console.ReadLine();
            if (int.TryParse(result, out value))
            {
                if (value >= 2 && value <=100)
                {
                    canexit = true;
                }
            }
        } while (!canexit);
        SetMax(value);
    }
    
    public override void DisplayGoal()
    {
        string completed = " ";
        
        if(_numberCompleted == _maxToComplete)
        {
            completed = "X";
        }
        Console.WriteLine($"[{completed}] {GetTitle()}: {GetDescription()} [{_numberCompleted} of {_maxToComplete} ]");
    }

    public override void FinishGoal()
    {
        SetTimesCompleted(GetTimesCompleted()+1);

        bool allGoalsCompleted = (GetTimesCompleted == GetMax);

        if (allGoalsCompleted)
        {
            Console.WriteLine("Congratulations! You have completed all of the goals of the checklist goal.");
            Manager.SetScore(Manager.GetScore() + GetValue());
        }
        else
        {
            Console.WriteLine("concradulations you completed another part of the goal");
            Manager.SetScore(Manager.GetScore() + GetEachValue());
        }
    }

}