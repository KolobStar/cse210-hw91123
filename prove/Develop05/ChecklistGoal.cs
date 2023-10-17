/*
Provide for a checklist goal that must be accomplished a certain number of times to be complete. 
Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
For example, if you set a goal to attend the temple 10 times, you might get 50 points each time you go, and then a bonus of 500 points on the 10th time.
*/

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