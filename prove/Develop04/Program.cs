using System;

class Program
{
    static void Main(string[] args)
    {
        // Define Variables
        // Build Menu, instance type and xecutable
        string [][] menu = new string[][] {new string [] {"Breathing","Exercise","Reflection","Listing","Quit"}, new string []{"BreathingActivity","ExerciseActivity","ReflectingActivity","ListingActivity","Exit"}}; 
        // rtvalue dtermins if we are exiting the program or not
        bool rtvalue = true;
        // the command number we are running 
        string command;

        do
        {
            for (int m = 0 ; m < menu[0].Length ; m++)
            {
                Console.WriteLine($"{m + 1} {menu[0][m]}");
            }
                Console.Write("Enter the number next to the option you would like to do: ");
                command = Console.ReadLine();

            // validate the command is a valid selection
            if ("12345".Contains(command) && command.Length == 1)
            {
                if (command == "5")
                {
                    rtvalue = false;
                }
                else
                {
                    Console.Clear();
                    int value = int.Parse(command);
                    string nameofActivityClass = menu[1][value - 1];
                    Type activityType = Type.GetType(nameofActivityClass);
                    if (activityType != null)
                    {
                        Activity activity = (Activity)Activator.CreateInstance(activityType);
                    }
            
                }
            }
        }while (rtvalue);
    }
}
        
