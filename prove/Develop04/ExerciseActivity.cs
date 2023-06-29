public class ExerciseActivity : Activity
{
    private string[] _exercises = {"Pushup", "Situp", "Jumping Jacks", "Running in place", "Lunges", "Pullups", "Arm Rotations", "Stretching"};
    private string[] _prompts = {"Up...", "Down..."};

    
    public ExerciseActivity()
    {
        Random random = new Random();
        int ex_selection = random.Next(_exercises.Length);

        SetName("Exercising");

        SetDescription($"In this activity you will get your heart rate up by peforming a physical exersize: {_exercises[ex_selection]}");


        // run the activity class display message 
        DisplayStartMessage();

        Console.WriteLine($"{_exercises[ex_selection]}");
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