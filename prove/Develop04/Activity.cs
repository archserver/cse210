public class Activity
{
    // set Variables for the Activity Classes
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    DateTime _endTime;
    string[] _spinner = {"|","/","-","\\", "|", "/","-","\\"};

    public Activity()
    {
    }

    public void SetName(string name)
    {
        _activityName = name;
        
    }

    public void SetDescription(string description)
    {
        _activityDescription = description;
    }

    public void DisplayStartMessage()
    {
        // set Variables
        int value;
        bool isValid;

        do
        {
            // first welcoming line to each class execution
            Console.WriteLine($"Welcome to the {_activityName} Activity.");
            // a description of the activity
            Console.WriteLine($"{_activityDescription}");

            Console.Write("How long, in seconds, would you like for your session? (20-200): ");
            string response = Console.ReadLine();

            // see if it is a number and output a number to the variable for the processing time
            isValid = int.TryParse(response, out value);

        // rerun if a non number was entered or a value outside of scope
        } while (!isValid || value < 20 || value > 200);
        Console.Clear();
        _activityDuration = value;

        // Get ready notification
        Console.WriteLine("Get Ready...");
        Spinner(5);

        // set the end time
        SetEnd();
    }

    public void DisplayEndMessage()
    {
        // information about the completed activity
        Console.WriteLine("Excellent Work");
        Console.WriteLine($"You have completed {_activityDuration} of the {_activityName} Activity.");
        Spinner(5);
        Console.Clear();
    }

    public void SetEnd()
    {
        _endTime = DateTime.Now.AddSeconds(_activityDuration);
    }

    public void Spinner(int delay)
    {
        // run the animated spinner program for the specified amount of delay time
        DateTime _spinningtime = DateTime.Now.AddSeconds(delay);
        int i = 0;

        while (DateTime.Now < _spinningtime)
        {
            Console.Write(_spinner[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i = (i+1) % _spinner.Length;
        }

    }

    public void Countdown(int delay)
    {
        // run the countdown timer showing time left based on the delay time
        DateTime _counter = DateTime.Now.AddSeconds(delay);
        int i = delay;
        
        while(DateTime.Now < _counter)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--;
        }

    }

    public DateTime GetEndTime()
    {
        return _endTime;
    }

    public int GetDuration()
    {
        return _activityDuration;
    }

}