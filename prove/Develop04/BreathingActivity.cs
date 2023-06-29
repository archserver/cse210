public class BreathingActivity : Activity
{
    private string[] _prompts = {"Breath In...", "Breath Out..."};
    
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("In this activity you will practice breathing in and out slowely as to lower your heart rate and reduce stress");

        // run the activity class display message 
        DisplayStartMessage();

        do
        {
            foreach (string prompt in _prompts)
            {
                Console.Write($"{prompt}");
                Countdown(4);
                Console.WriteLine("");
            }
        }while (DateTime.Now < GetEndTime());

        DisplayEndMessage();

    }
}