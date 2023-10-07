using System;

public class ListingActivity : Activity

{
    public int _count;

    public List<string> _prompts { get; set; } = new List<string>();



    public ListingActivity()
    {
        _name = "Listing Activity";
        Console.WriteLine("");
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
    public void Run()
    {
       
        DisplayStartingMessage();
        ShowSpinner(5);
        GetRandomPrompt();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int i = rand.Next(_prompts.Count() - 1);//it gives us a random number from 0 to the max index of _prompts
        Console.WriteLine(_prompts[i]);
        ShowCountDown(10);
        Console.WriteLine("");
        Console.WriteLine("Type as many examples you have ");
        List<string> userInput = GetListFromUser();
        Console.WriteLine($"You entered {userInput.Count()} examples. ");

    }
    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        List<string> userInput = new List<string>();
     
        do
        {
            string input = Console.ReadLine();
            userInput.Add(input);
        } while (DateTime.Now <= endTime );
        return userInput;
    }


}

