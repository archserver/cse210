using System;
//using System.Windows.Forms;

public class Program
{
   // private static MainForm mainForm; // Replace 'MainForm' with the actual class name of your main GUI form

    [STAThread]
    public static void Main()
    {
        // Define Arrays to store the program information in 
        List<Map> maps = new List<Map>();

        // load maps 
        Console.WriteLine(" Loading Maps");
        Console.WriteLine($"{maps}");

        // try and load map file
        if (maps == null)
        {
            Console.WriteLine("No Maps enter first map");
            // enter map information

            // append map to maps
            //save maps

        }
        else foreach(Map map in maps)
        {
            Console.WriteLine("Show list of mas allow selection");
            // list maps make selection 
            // load menu of options
        }

//        Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);

        // Create an instance of the main GUI form
 //       mainForm = new MainForm(); // Replace 'MainForm' with the actual class name of your main GUI form

        // Run the application
 //       Application.Run(mainForm);
    }
}