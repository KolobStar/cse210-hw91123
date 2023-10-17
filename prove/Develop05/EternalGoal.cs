/*Provide for eternal goals that are never complete, but each time the user records them, they gain some value.
For example, every time you read your scriptures you get 100 points.
*/
using System;

public class EternalGoal : GoalManager
{
    public EternalGoal()
    {
        name = "Eternal Goal";

        description = "This goal will help you to get 100 points every time you complete a goal. ";
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