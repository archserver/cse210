using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

//using System.Windows.Forms;

public class Program
{
   // private static MainForm mainForm; 
   // define static file storage location for the Chemical Release Program Data Files
    private static string filePath = "CRfiles\\";
    // Define List to store the program map information in
    private static List<Map> maps = new List<Map>();
    private static List<Chemical> fullChemicalList = new List<Chemical>();
    private static List<Person> fullPersonList = new List<Person>();

    [STAThread]
    public static void Main()
    {
        

        LoadStartupFiles(filePath);

        foreach(Map map in maps)
        {
            Console.WriteLine("Show list of map allow selection");
            // list maps make selection 
            // load menu of options
        }

        // with selected map 

        // show menu allow selection
        // 1 Track New Release Pattern
                // choose chemical
                // define location of release
                // gather weather information
                // choose Incident Commander
                // Map path
                // Save New release to file
        // 2 Show a historical Release Pattern
                // Load Releases
                // Allow selection
                // View Release Information in sub window of map with pattern window
        // 3 Edit Sites
                // Create a new site
                // Edit an existing site
                // Delete a site
        // 4 Edit Chemicals
                //Add a new chemical
                //Edit an existing chemical
                //Delete a chemical
        // 5 Edit People
                //Add a new person
                //Edit an existing person
                //Delete a person


//        Application.EnableVisualStyles();
        //Application.SetCompatibleTextRenderingDefault(false);

        // Create an instance of the main GUI form
 //       mainForm = new MainForm(); // Replace 'MainForm' with the actual class name of your main GUI form

        // Run the application
 //       Application.Run(mainForm);
    }
    
    public static void LoadStartupFiles(string filePath)
    {
        // Load the chemical file
        Console.WriteLine("Loading Chemicals");
        // try and load chemical file
        LoadChemical( filePath);
        if (fullChemicalList.Count == 0)
        {
            Console.WriteLine("No chemicals found. Enter first chemical");
            // enter chemical information
            // append chemical to chemicallist
            //save chemicallist
        }
/*          else foreach(Chemical chemical in fullChemicalList)
        {
            Console.WriteLine("Show list of chemicals allow selection");
            // list chemicals make selection 
        }*/
        Console.WriteLine($"{fullChemicalList}");

        // Load the person file
        Console.WriteLine("Loading People");
        // try and load person file
        LoadPerson(filePath);
        if (fullPersonList.Count == 0)
        {
            Console.WriteLine("No people found. Enter first person");
            // enter person information
            // append person to personlist
            //save personlist
        }
/*          else foreach(Person person in fullPersonList)
        {
            Console.WriteLine("Show list of people allow selection");
            // list person make selection 
        }*/
        Console.WriteLine($"{fullPersonList}");

        // Load the Maps file
        Console.WriteLine("Loading Maps");
        // try and load map file
        LoadMaps(filePath);
        if (maps.Count == 0)
        {
            Console.WriteLine("No maps found. Enter first map");
            // enter map information
            // append map to maps
            //save maps
        }
        Console.WriteLine($"{maps}");
    }

    public static void LoadChemical(string filePath)
    {
         string fullPath = filePath+"Chemicals.json";
        try
        {
            if (File.Exists(fullPath))
            {
                string json = File.ReadAllText(fullPath);
                fullChemicalList = JsonSerializer.Deserialize<List<Chemical>>(json);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading chemicals: {ex.Message}");
        }
    }
    public static void LoadPerson(string filePath)
    {
        string fullPath = filePath+"People.json";
        try
        {
            if (File.Exists(fullPath))
            {
                string json = File.ReadAllText(fullPath);
                fullPersonList = JsonSerializer.Deserialize<List<Person>>(json);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading people: {ex.Message}");
        }
        
    }
    public static void LoadMaps(string filePath)
    {
        string fullPath = filePath+"Maps.json";
        try
        {
            if (File.Exists(fullPath))
            {
                string json = File.ReadAllText(fullPath);
                maps = JsonSerializer.Deserialize<List<Map>>(json);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading maps: {ex.Message}");
        }
    }
    
    public static void SaveMaps(string filePath)
    {
        string fullPath = filePath+"Maps.json";
        try
        {
            string json = JsonSerializer.Serialize(maps);
            File.WriteAllText(filePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving maps: {ex.Message}");
        }
     }
}