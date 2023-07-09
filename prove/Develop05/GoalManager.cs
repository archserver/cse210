using System;
using System.Text.RegularExpressions;
using System.IO;

public class GoalManager
{
    // set Variables for the GoalManager
    string _userID;
    //Build a list of Goals
    List<Goal> _goals = new List<Goal>();
    // keep track of the users score
    private int _score;
          
    public GoalManager()
    {
    }

    public void EnterUserID()
    {
        string iD;
        bool validUser = false;
        string response = "";

        do 
        {
            do
            {
                Console.Write("Please enter your User ID: ");
                iD = Regex.Replace(Console.ReadLine(),StringUtility.Pattern,"");
                iD = iD.Replace(" ","");    
            } while (iD.Length < 1);

            validUser = DoesFileExist(iD);

            if (!validUser)
            {
                do
                {
                    Console.Write("Is this a new User (Y/N)? ");
                    response = Console.ReadLine().ToUpper();
                } while (response != "Y" && response != "N");

                if (response == "Y")
                {
                    validUser = true;
                }

            }
            else
            {
                LoadGoalFile(iD);
            }

        } while (!validUser);

        _userID = iD;
    }

    public void DisplayMenu(  )
    {
        // Build Menu, instance type and executable
        string [][] menu = new string[][] {new string [] {"Create a Simple Goal","Create a Eternal Goal","Create a Checklist Goal","Create a Milestone Goal","Show a list of Goals","Record A Goal Status Update", "Quit"}, 
            new string []{"SimpleGoal","EternalGoal","CheckListGoal","MilestoneGoal","ListGoals","UpdateGoal","Exit"}}; 
        
                // rtvalue dtermins if we are exiting the program or not
        bool rtvalue = true;
        // the command number we are running 
        string command;


        do
        {
            if (_goals.Count < 3)
            {
                Console.WriteLine($"You have {_goals.Count()} goals listed please create more goals");
            }

            Console.WriteLine($"Score: {_score}");
            for (int m = 0 ; m < menu[0].Length ; m++)
            {
                Console.WriteLine($"{m + 1} {menu[0][m]}");
            }
                Console.Write("Enter the number next to the option you would like to do: ");
                command = Console.ReadLine();

            // validate the command is a valid selection
            if ("1234567".Contains(command) && command.Length == 1)
            {
                if (int.TryParse(command, out int selection) && selection == menu[0].Length)
                {
                    rtvalue = false;
                }
                else if("1234".Contains(command))
                {
                    Console.Clear();
                    int value = int.Parse(command);
                    string nameofGoalClass = menu[1][value - 1];
                    Type goalType = Type.GetType(nameofGoalClass);
                    if (goalType != null)
                    {
                        Goal goal = (Goal)Activator.CreateInstance(goalType, this);

                        if (goal != null)
                        {
                            goal.FillInInfo();
                            _goals.Add(goal);
                            SaveGoalFile(_userID);
                        }
                    }
            
                }
                else
                {
                    switch(command)
                    {
                        case "5":
                            ListGoals();
                            if (_goals == null)
                            {
                                Console.WriteLine("No Goals");
                                CountDown(5);
                            }
                            else
                            {
                                CountDown(_goals.Count * 5);
                            }
                        break;
                        case "6":
                            UpdateGoal();
                            SaveGoalFile(_userID);
                            CountDown(5);
                        break;
                        default:
                            Console.WriteLine("Invalid Menu Selection, check out why!");
                        break;
                    }
                }
            }
            Console.Clear();
        }while (rtvalue);

    }

    public bool DoesFileExist(string filename)
    {
        bool exist = false;
        // Check if the goal file exists
        string filePath = "files/"+filename + ".goal";
        if (File.Exists(filePath))
        {
            exist = true;
        }
        else
        {
            Console.WriteLine($"{filePath} Goal file not found.");
        }

        return exist; 
        
    }

    public void LoadGoalFile(string filename)
    {
        string filePath = "files/" + filename + ".goal";
        string[] lines = System.IO.File.ReadAllLines(filePath);
        int _lineNumber = 0;
        int _goalType, _value, _timesCompleted, _qty;
        bool _status;
        string _title, _description;

        foreach (string line in lines)
        {
            // split the string into Parts
            string[] parts = line.Split(",");
            // process the header information line
            if (_lineNumber == 0)
            {
                SetScore(int.Parse(parts[0]));
            }
            else
            {
                _goalType = int.Parse(parts[0]); //Get the goal type for prper loading
                switch ((GoalType)_goalType)
                {
                    case GoalType.Simple:
                    // load simple type
                      SimpleGoal simple = new SimpleGoal(this);
                      _status = bool.Parse(parts[1]); // Bool for complete or not
                      _value = int.Parse(parts[2]); // Value of goal in points to increase score
                      _title = parts[3]; // The title of the goal
                      _description = parts[4];
                      
                      simple.SetCompleted(_status);
                      simple.SetValue(_value);
                      simple.SetTitle(_title);
                      simple.SetDescription(_description);

                      _goals.Add(simple);
                    
                    break;
                    case GoalType.Eternal:
                      EternalGoal eternal = new EternalGoal(this);
                      _timesCompleted = int.Parse(parts[1]);// number of times the goal has been completed
                      _value = int.Parse(parts[2]); // Value of goal in points to increase score
                      _title = parts[3]; // The title of the goal
                      _description = parts[4];

                      eternal.SetTimesCompleted(_timesCompleted);
                      eternal.SetValue(_value);
                      eternal.SetTitle(_title);
                      eternal.SetDescription(_description);

                      _goals.Add(eternal);
                    break;
                    case GoalType.Checklist: // CheckList
                        CheckListGoal checklist = new CheckListGoal(this);
                        int _maxQty = int.Parse(parts[1]);
                        _qty = int.Parse(parts[2]); // number of times completed of CheckList goal
                        _value = int.Parse(parts[3]); // Value of goal in points to increase score
                        int _valueeach = int.Parse(parts[4]);
                        _title = parts[5]; // The title of the goal
                        _description = parts[6];

                        checklist.SetMax(_maxQty);
                        checklist.SetTimesCompleted(_qty);
                        checklist.SetValue(_value);
                        checklist.SetEachValue(_valueeach);
                        checklist.SetTitle(_title);
                        checklist.SetDescription(_description);
                        
                        _goals.Add(checklist);

                    break;
                    case GoalType.Milestone: // Milestone
                        MilestoneGoal milestone = new MilestoneGoal(this);
                        _qty = int.Parse(parts[1]); // number of subparts to the Milestone goal
                        _value = int.Parse(parts[2]); // Value of goal in points to increase score
                        _title = parts[3]; // The title of the goal
                        _description = parts[4];
                        for (int i = 5; i < parts.Length; i++)
                        {
                            SimpleGoal subMilestone = new SimpleGoal(this);
                            string[] atoms = parts[i].Split("~");

                            bool subStatus = bool.Parse(atoms[0]); // Bool for complete or not
                            int subValue = int.Parse(atoms[1]); // Value of goal in points to increase score
                            string subTitle = atoms[2]; // The title of the goal
                            string subDescription = atoms[3];  // The Description of the goal
                            
                            subMilestone.SetCompleted(subStatus);
                            subMilestone.SetValue(subValue);
                            subMilestone.SetTitle(subTitle);
                            subMilestone.SetDescription(subDescription);

                            milestone.AddSubGoal(subMilestone);
                                
                        }
                        milestone.SetValue(_value);
                        milestone.SetTitle(_title);
                        milestone.SetDescription(_description);
                        _goals.Add(milestone);

                    break;
                }
            }
            _lineNumber ++;
        }
    }

    public void SaveGoalFile(string filename)
    {
        string filePath = "files/" + filename + ".goal";
        StreamWriter theSaveFile = null;

        try
        {
            theSaveFile = new StreamWriter(filePath);
            // Write the header information
            theSaveFile.WriteLine($"{GetScore()}");

            // Write the details of each goal
            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal simple)
                {
                    theSaveFile.WriteLine($"{(int)GoalType.Simple},{simple.GetCompleted()},{simple.GetValue()},{simple.GetTitle()},{simple.GetDescription()}");
                }
                else if (goal is EternalGoal eternal)
                {
                    theSaveFile.WriteLine($"{(int)GoalType.Eternal},{eternal.GetTimesCompleted()},{eternal.GetValue()},{eternal.GetTitle()},{eternal.GetDescription()}");
                }
                else if (goal is CheckListGoal checklist)
                {
                    theSaveFile.WriteLine($"{(int)GoalType.Checklist},{checklist.GetMax()},{checklist.GetTimesCompleted()},{checklist.GetValue()},{checklist.GetEachValue()},{checklist.GetTitle()},{checklist.GetDescription()}");
                }
                else if (goal is MilestoneGoal Milestone)
                {
                    theSaveFile.Write($"{(int)GoalType.Milestone},{Milestone.GetSubGoals().Count},{Milestone.GetValue()},{Milestone.GetTitle()},{Milestone.GetDescription()}");

                    foreach (SimpleGoal subGoal in Milestone.GetSubGoals())
                    {
                        theSaveFile.Write($",{subGoal.GetCompleted()}~{subGoal.GetValue()}~{subGoal.GetTitle()}~{subGoal.GetDescription()}");
                    }
                    theSaveFile.WriteLine("");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An Error has occured: {ex.Message}");
            CountDown(25);
        }
        finally
        {
            theSaveFile?.Close();
        }
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int s)
    {
        _score = s;
    }

    public void SetUserID(string iD)
    {
        _userID = iD;
    }

    public string GetUserID()
    {
        return _userID;
    }

    public void ListGoals()
    {
        // display a list of all of the goals in the array of _goals
       foreach(Goal goal in _goals) 
       {
            goal.DisplayGoal();
       }
    }

    public void UpdateGoal()
    {
        int _counter = 1;
        int value;
        bool canexit = false;

        foreach(Goal goal in _goals)
        {
            if(goal.GetCompleted())
            {
                Console.WriteLine($"Complated {goal.GetTitle()}");
            }
            else
            {
                Console.WriteLine($"{_counter}. {goal.GetTitle()}");
            }
            _counter++;
        }

        do
        {
            Console.Write("Enter the Number next to the Goal you would like to marke as having completed:");
            string result = Console.ReadLine();
            if (int.TryParse(result, out value))
            {
                if (value >= 1 && value <=_counter)
                {
                    canexit = true;
                }
            }
        } while(!canexit);

        _goals[value-1].FinishGoal();
        //update the status of a goal
    }

    public void CountDown(int delay)
    {
        // run the countdown timer showing time left based on the delay time
        DateTime _counter = DateTime.Now.AddSeconds(delay);
        int i = delay;
        
        while(DateTime.Now < _counter)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i >= 100)
            {
                Console.Write("\b \b");
            }
            if (i >= 10)
            {
                Console.Write("\b \b");
            }
            Console.Write("\b \b");
            i--;
        }

    }
}

