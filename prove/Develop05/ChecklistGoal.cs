using System;

public class ChecklistGoal : GoalManager
{
    public int _amoutCompleted;
    public int _target;
    public int _bonus;

    public ChecklistGoal()
    {
        name =" Checklist Goal ";
        description ="The checklist Goal have to be completed a particular number of times. You gain value each time this goal is recorded, but when you reach the goal, you will get a bonus.";
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