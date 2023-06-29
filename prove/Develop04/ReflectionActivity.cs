public class ReflectingActivity : Activity
{
    private string[] _prompts = {"Think of a time when you stood up for what was right", 
        "Think of a time you were caring", "Think of an experience where you were selfless", 
        "Think of a time when you helped a stranger", "Think of a time you went the extra mile" };
    private string[] _reflections = {"What was the most meaningful part of the experience?", 
        "What was the effect of others around you?", "How did this experience help you?",
        "What did you learn from this experience?", "How did the event start?", 
        "What is the difference between this timne and other times which we not so amazing?"};

    
    public ReflectingActivity()
    {
        // declare variables
        Random random = new Random();
        // select a random prompt for reflecting on
        int ref_selection = random.Next(_prompts.Length);
        

        SetName("Reflecting");

        SetDescription("In this activity you help you reflect on important events in your life");


        // run the activity class display message 
        DisplayStartMessage();

        // Display the Reflection prompt item
        Console.WriteLine(_prompts[ref_selection]);

        // Determin the amount of time to spend on each reflection part
        int reftime = GetDuration() / _reflections.Length;
        int remainder = GetDuration() % _reflections.Length;

        // run through each part of reflection
        foreach (string reflection in _reflections)
        {
            Console.Write($"{reflection}");
            Countdown(reftime);
            Console.WriteLine("");
        }
        if (remainder > 0)
        {
            Spinner(remainder);
        }
        DisplayEndMessage();
    }
}