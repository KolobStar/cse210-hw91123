//Gloria Estrella
//This file contains the data of the entries 
using System;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    public string prompt;
    public string response;
    public DateTime date;
    public string _name;
    public string _description;
    public int _duration;

    public Activity()
    {
        this.date = DateTime.Now;// thisone stores the date when is created
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Get Ready...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}. ");// we injected the duration and the name of the activity into the comentS
    }

    public void ShowSpinner(int seconds)//prep work for now  we are showing the time in milliseconds
    {
        Console.WriteLine(seconds * 100);
        Thread.Sleep(seconds * 100);
    }

    public void ShowCountDown(int seconds)//prep work we are decremanting the seconds and printing each number on the scring
    {


        int milliseconds = seconds * 100;

        do
        {
            Console.WriteLine(seconds);
            Thread.Sleep(seconds * 100);
            seconds--;
        } while (seconds > 0);
    }
    public Activity(DateTime date)
    {
        this.date = date;// thisone stores the date from the loaded file
    }

    public void Write(string prompt, string response)//stores the prompt and response of the input
    {
        this.prompt = prompt;
        this.response = response;


    }
    public string Read()
    {
        return date + "\n" + prompt + "\n" + response;

    }

    public override string ToString()
    {
        return date + "~~" + prompt + "~~" + response;// creates string foer saving and loading  with the IO
    }



}