public class ListingActivity : Activity
{
    private string[] _prompts = {"Who are some people that you appreciate?", 
        "What are some of your best strengths?", "Ia there anyone you helped this week?", 
        "Who are your personal heros", "What was an accomplishment of yours this week?" };
    int _numberofItems;

    
    public ListingActivity()
    {
        // declare variables
        Random random = new Random();
        // select a random prompt for the Question
        int que_selection = random.Next(_prompts.Length);
        

        SetName("Listing");

        SetDescription("In this activity you will list as many items in reference to the question that you can in the time period");


        // run the activity class display message 
        DisplayStartMessage();

        // Display the Listing prompt item
        Console.WriteLine("List as many rersponses to the following question as you can in the time alloted:");
        Console.WriteLine("----- "+_prompts[que_selection]+" -----");
        Console.WriteLine(" You may begin in: ");
        Countdown(6);

        _numberofItems = EnterItems();
        
        Console.WriteLine($"You listed {_numberofItems} items!");
        
        DisplayEndMessage();
    }

    public int EnterItems()
    {
        int i = 0;
        do
        {
            Console.Write("> ");
            Console.ReadLine();
            i++;
        } while (DateTime.Now < GetEndTime());

        return i;
    }

}