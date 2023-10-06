//Gloria Estrella

using System;


class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _name = "Welcome to the Breathing Activity. ";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        Console.WriteLine("");
    }

    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);

        int i = 0;
        do
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            i += 4;
        } while (i < _duration);

        DisplayEndingMessage();


    }

    


}
