//Gloria Estrella
//Main File
using System;
//the IO helps to work read and write other files
using System.IO;

class Program
{
    static void Main(string[] args)
    {



        Random random = new Random(); //to get a random numbers

        while (true)
        {
            Console.WriteLine("Select a Mindfulness Activity from the menu ");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breating activity ");
            Console.WriteLine("2. Start Reflecting activity ");
            Console.WriteLine("3. Start Listing Activity  ");
            Console.WriteLine("4. Quit ");

            string input = Console.ReadLine();

            if (input == "4")// handle the quit choice
            {
                break;
            }

            switch (Convert.ToInt32(input))
            {
                case 1:
                    BreathingActivity breathingactivity = new BreathingActivity();
                    Console.WriteLine(breathingactivity._name);
                    Console.WriteLine(breathingactivity._description);
                    Console.WriteLine("How much time in seconds you want your session to last? ");
                    input = Console.ReadLine();
                    breathingactivity._duration = Convert.ToInt32(input);//taking string and converting numbers int
                    breathingactivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingactivity = new ReflectingActivity();
                    Console.WriteLine(reflectingactivity._name);
                    Console.WriteLine(reflectingactivity._description);
                    Console.WriteLine("How much time in seconds you want your session to last? ");
                    input = Console.ReadLine();
                    reflectingactivity._duration = Convert.ToInt32(input);//taking string and converting numbers int
                    reflectingactivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    Console.WriteLine(listingActivity._name);
                    Console.WriteLine(listingActivity._description);
                    break;
                case 4:
                default:
                    break;
            };

            //         else if (input == "1")//handels creating entries

            //         {
            //             Console.WriteLine("You have chosen Reflection Activity");
            //             Thread.Sleep(2000);
            //             Console.Write("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

            //             string[] prompts = new string[] {

            //         };

            //             int p = random.Next(prompts.Length);
            //             Console.WriteLine(prompts[p]);
            //             Console.Write("> ");

            //             input = Console.ReadLine();
            //             breatingactivity.Write(prompts[p], input);

            //         }

            //         else if (input == "2")//handels creating entries
            //         {
            //             Console.WriteLine("You have chosen the Reflection Activity");
            //             Thread.Sleep(2000);
            //             Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life." + "");
            //             Thread.Sleep(3000);// This is a sleep timer of 3 seconds 
            //             Console.Write("");
            //             Console.WriteLine("Are you ready?");
            //             for (int i = 5; i > 0; i--)//This is a counting down timer of 5 seconds 
            //             {
            //                 Console.Write(i);
            //                 Thread.Sleep(1000);
            //                 Console.Write("\b \b");
            //             }
            //             string[] prompts = new string[] {
            //                 "Think of a time when you stood up for someone else.",
            //                 "Think of a time when you did something really difficult.",
            //                 "Think of a time when you helped someone in need.",
            //                 "Think of a time when you did something truly selfless."


            //         };
            //             int p = random.Next(prompts.Length);
            //             Console.WriteLine(prompts[p]);
            //             Console.Write("> ");

            //             input = Console.ReadLine();
            //             breatingactivity.Write(prompts[p], input);

            //         }

            //         else if (input == "3")//handels creating entries
            //         {
            //             Console.WriteLine("You have chosen the Listin activity");
            //             Thread.Sleep(2000);
            //             Console.WriteLine("This activity will help you to reflect on the good things in your life by having you list as many things as you can in a certain area.");
            //             Thread.Sleep(3000);
            //             Console.WriteLine("Below we have selected questions at random, please answer the question that has been selected. ");
            //             Console.WriteLine("");

            //             List<string> animationTimerStrings = new List<string>(); //This a 8 seconds animation timer
            //             animationTimerStrings.Add("|");
            //             animationTimerStrings.Add("/");//Why 8 secods? because each string in the list last 1 second.
            //             animationTimerStrings.Add("-");
            //             animationTimerStrings.Add("\\"); //To avoid the ((\) backslash) error you have to add anothern, so you mus have 2 (\\).
            //             animationTimerStrings.Add("|");
            //             animationTimerStrings.Add("/");
            //             animationTimerStrings.Add("-");
            //             animationTimerStrings.Add("\\");

            //             foreach (string s in animationTimerStrings) //this helps the animation timer run
            //             {
            //                 Console.Write(s);
            //                 Thread.Sleep(1000);
            //                 Console.Write("\b \b");
            //             }


            //             string[] prompts = new string[] {
            //             "Who are people that you appreciate? ",
            //             "What are personal strengths of yours? ",
            //             "Who are people that you have helped this week? ",
            //             "When have you felt the Holy Ghost this month? ",
            //             "Who are some of your personal heroes? "
            //         };

            //             int p = random.Next(prompts.Length);
            //             Console.WriteLine(prompts[p]);
            //             Console.Write("> ");

            //             input = Console.ReadLine();
            //             breatingactivity.Write(prompts[p], input);

            //         }

        }
    }
}