public class MilestoneGoal: Goal
{
    private List<SimpleGoal> subGoals;

    public MilestoneGoal(GoalManager manager) : base(manager) 
    {
        Type = GoalType.Milestone;
        subGoals = new List<SimpleGoal>();
    }

    public override bool GetCompleted()
    {
        bool rtvalue = true;

        foreach(SimpleGoal subgoal in subGoals)
        {
            if(!subgoal.GetCompleted())
            {
                rtvalue = false;
            }
        }
        return rtvalue;
    }

  
    public void AddSubGoal(SimpleGoal sG)
    {
        subGoals.Add(sG);
    }

    public List<SimpleGoal> GetSubGoals()
    {
        return subGoals;
    }

    public override void FillInInfo()
    {
        // Enter information for Milestone Goal
        EnterTitle();
        EnterDescription();
        EnterValue();
        EnterSubGoals();
    }

   public void EnterSubGoals()
    {
        string subGoalTitle;
        do
        {
            if (subGoals == null)
             {
                Console.WriteLine("SubGoal #1 enter \"End\" to exit extry");
             }
             else
             {
                Console.WriteLine($"SubGoal #{subGoals.Count+1} enter \"End\" to exit entry");
             }
            // collect a list of the subgoals
            SimpleGoal subGoal = new SimpleGoal(Manager);

            subGoal.EnterTitle();
            subGoalTitle = subGoal.GetTitle().ToUpper();
            if(subGoalTitle != "END" && subGoalTitle.Length > 1)
            {
                subGoal.EnterDescription();
                subGoal.EnterValue();
                subGoals.Add(subGoal);
            }
            else
            {
                if (subGoals.Count < 2)
                {
                    Console.WriteLine("There must be at mininum of two sub goals for a cheklist goal");
                }
            }
        }while(subGoalTitle != "END" || subGoals.Count < 2);
    }
    
    public override void DisplayGoal()
    {
        int percentComplete;
        int numberCompleted = 0;

        foreach (var subGoal in subGoals)
        {
            if (subGoal.GetCompleted())
            {
                numberCompleted++;
            }
        } 
        percentComplete = (numberCompleted * 100) / subGoals.Count;
        Console.WriteLine($"[{percentComplete}%] {GetTitle()}: {GetDescription()}");
        Console.WriteLine("Sub-goals:");
        foreach (var subGoal in subGoals)
        {
            subGoal.DisplayGoal();
        }
    }

    public override void FinishGoal()
    {
        int _counter = 1;
        int value;
        bool canexit = false;

        foreach( var subGoal in subGoals)
        {
            if(subGoal.GetCompleted())
            { 
                Console.WriteLine($"Completed {subGoal.GetTitle()}");
            }
            else
            {
                Console.WriteLine($"{_counter}. {subGoal.GetTitle()}");
            }
            _counter++;
        }

         do
        {
            Console.Write("Enter the Number next to the SubGoal you would like to marke as having completed: ");
            string result = Console.ReadLine();
            if (int.TryParse(result, out value))
            {
                if (value >= 1 && value <=_counter && !subGoals[value-1].GetCompleted())
                {
                    canexit = true;
                }
            }
        } while(!canexit);

        subGoals[value-1].FinishGoal();

        bool allSubGoalsCompleted = subGoals.All(subGoal => subGoal.GetCompleted());
        if (allSubGoalsCompleted)
        {
            Console.WriteLine("Congratulations! You have completed all the sub-goals of the Milestone goal.");
            Manager.SetScore(Manager.GetScore() + GetValue());
        }
        else
        {
            Console.WriteLine("Not all sub-goals are completed yet.");
        }
    }

}