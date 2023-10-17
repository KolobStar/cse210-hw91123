using System;
using System.IO;
using System.Text;

public class GoalManager
{
    public string name;
    public string description;
    public int points;
    public List<string> _goals { get; set; } = new List<string>();

    public int _score;

    public GoalManager()
    {

    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {

    }

    public void CreateGoal()
    {

    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string input = Console.ReadLine();
        string path = @"c:\temp\" + input; 
        try{
        // Create the file, or overwrite if the file exists.
        using (StreamWriter fs = File.AppendText(input))
        {
            string goal = "This is my goal";
            // Add some information to the file.
            fs.Write(goal);
        }
        } catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
    public void LoadGoal()
    {

    }


}