using System;

public class ReflectingActivity : Activity
{
    public List<string> _prompts {get;set;}= new List<string>();
    public List<string> _questions {get;set;}= new List<string>();

    public ReflectingActivity()
    {

        _name = "Welcome to the Reflecting Activity. ";
        Console.WriteLine("");
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");

    }

    public void Run()
    {
        Console.WriteLine(GetRandomPromt());
    }

    public string GetRandomPromt()
    {
        Random rand = new Random();
        int i = rand.Next(_prompts.Count() - 1);//it gives us a random number from 0 to the max index of _prompts
        return _prompts[i];
    }

    public string GetRandomQuestion()
    {


        return null;
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }



}



