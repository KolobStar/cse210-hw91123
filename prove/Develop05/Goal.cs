using System;

public class Goal: GoalManager
{
    public string _shortName;
    public string _description;
    public string _points;

    public Goal()
    {
        
    }


    public Goal(string name, string description, int points)
    {

    }

    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true;
    }

    public string GetDetailsString()
    {
        return string.Empty;
    }

    public string GetStringRepresentation()
    {
        return string.Empty;
    }



}