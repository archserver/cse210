public class EternalGoal: Goal
{
    private int _timesCompleted = 0;


    public EternalGoal(GoalManager manager) : base(manager) 
    {
        Type = GoalType.Eternal;
    }

    public override bool GetCompleted()
    {
        return false;
    }

    public void SetTimesCompleted(int qty)
    {
        _timesCompleted = qty;
    }

    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    
    public override void DisplayGoal()
    {
        Console.WriteLine($"[{_timesCompleted}] {GetTitle()}: {GetDescription()}");
    }

    public override void FinishGoal()
    {
        int i = GetTimesCompleted()+1;

        SetTimesCompleted(i);
        Console.WriteLine($"Congradulations on the {i} completion of: {GetTitle()}");
        Manager.SetScore(Manager.GetScore() + GetValue());
    }
}