//Gloria Estrella
//Main Class 
using System;
using System.Security.Cryptography.X509Certificates;

public class Activity
{ 
    public string _name;
    public string _description;
    public int _duration;

    public Activity()
    {

    }

   
    public void DisplayStartingMessage()
    {
        Console.WriteLine("Get Ready...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}. ");// I injected the duration and the name of the activity into the comentS
    }

    public void ShowSpinner(int seconds)//This shows the spiner and  the time in milliseconds
    {
        List<string> animationTimerStrings = new List<string>(); //This a 8 seconds animation timer
        animationTimerStrings.Add("|");
        animationTimerStrings.Add("/");//Why 8 secods? because each string in the list last 1 second.
        animationTimerStrings.Add("-");
        animationTimerStrings.Add("\\"); //To avoid the ((\) backslash) error you have to add anothern, so you mus have 2 (\\).
        animationTimerStrings.Add("|");
        animationTimerStrings.Add("/");
        animationTimerStrings.Add("-");
        animationTimerStrings.Add("\\");

        int i = 0;
        do
        {


            foreach (string s in animationTimerStrings) //this helps the animation timer run
            {
                Console.Write(s);
                Thread.Sleep(125);
                Console.Write("\b \b");

            }
            i++;// it adds one to i every time it loops back aroun to the i
        } while (i <= seconds);
    }

    public void ShowCountDown(int seconds)//This is decremanting the seconds and printing each number on the scring
    {


        do
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds=seconds-1;
        } while (seconds >= 0);
        Console.WriteLine("");
    }


}