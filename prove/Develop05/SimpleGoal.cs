/*Provide for simple goals that can be marked complete and the user gains some value.
For example, if you run a marathon you get 1000 points.
*/
using System;

public class SimpleGoal : GoalManager
{
    public bool _isComplete;


    public SimpleGoal()
    {
        name = "Simple Goal";
        description = "This Goal Will Help you to get points depending in what  simple goal you do";
    }
    public void RecordEvent()
    {

    }

    public bool IsComplete()
    {
        return true;
    }


    public string GetStringRepresentation()
    {
        return string.Empty;
    }
}