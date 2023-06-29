public class ExersiseActivity : Activity
{
    private string[] _exersises = {"Pushup", "Situp", "Jumping Jacks", "Running in place", "Lunges", "Pullups", "Arm Rotations", "Stretching"};
    private string[] _prompts = {"Up...", "Down..."};

    
    public ExersiseActivity()
    {
        Random random = new Random();
        int ex_selection = random.Next(_exersises.Length);

        SetName("Exersising");

        SetDescription($"In this activity you will get your heart rate up by peforming a physical exersize: {_exersises[ex_selection]}");


        // run the activity class display message 
        DisplayStartMessage();

        Console.WriteLine($"{_exersises[ex_selection]}");
        do
        {
            foreach (string prompt in _prompts)
            {
                Console.Write($"{prompt}");
                Countdown(4);
                Console.Beep();
                Console.WriteLine("");
            }
        }while (DateTime.Now < GetEndTime());

        DisplayEndMessage();

    }
}