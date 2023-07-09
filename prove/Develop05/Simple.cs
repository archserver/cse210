public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal(GoalManager manager) : base(manager) 
    {
        Type = GoalType.Simple;
    }

    public void SetCompleted(bool b)
    {
        _completed = b;
    }

    public override bool GetCompleted()
    {
        return _completed;
    }
    
    public override void DisplayGoal()
    {
        string checkBox = " ";
        if (_completed)
        {
            checkBox = "X";
        }

        Console.WriteLine($"[{checkBox}] Title: {GetTitle()}: {GetDescription()}");
    }

    public override void FinishGoal()
    {
        SetCompleted(true);
        Console.WriteLine($"Congradulations on completing: {GetTitle()}");
        Manager.SetScore(Manager.GetScore() + GetValue());
    }
}