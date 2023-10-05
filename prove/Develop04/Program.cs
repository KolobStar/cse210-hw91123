//Gloria Estrella
//Main File
using System;
//the IO helps to work read and write other files
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // cotain entries
        BreatingActivity breatingactivity = new BreatingActivity();
        //to get a random numbers 
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Select a Mindfulness Activity from the menu ");
            Thread.Sleep(2000);
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breating activity ");
            Console.WriteLine("2. Start Reflecting activity ");
            Console.WriteLine("3. Start Listing Activity  ");
            Console.WriteLine("4. Quit ");


            string input = Console.ReadLine();
            // handle the quit choice
            if (input == "4")
            {
                break; 
            }

            else if (input == "1")//handels creating entries

            {
                Console.WriteLine("You have chosen Reflection Activity");
                Thread.Sleep(2000);
                Console.Write("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                string[] prompts = new string[] {
                /*
                1. After the starting message, the user is shown a series of messages alternating between "Breathe in..." and "Breathe out..."
                2. After each message, the program should pause for several seconds and show a countdown.
                3. It should continue until it has reached the number of seconds the user specified for the duration.
                4. The activity should conclude with the standard finishing message for all activities.*/
            };

                int p = random.Next(prompts.Length);
                Console.WriteLine(prompts[p]);
                Console.Write("> ");

                input = Console.ReadLine();
                breatingactivity.Write(prompts[p], input);

            }

            else if (input == "2")//handels creating entries
            {
                Console.WriteLine("You have chosen the Reflection Activity");
                Thread.Sleep(2000);
                Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life." + "");
                Thread.Sleep(2000);
                Console.WriteLine("");
                string[] prompts = new string[] {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless."
                    /*After displaying the prompt, the program should ask the to reflect on questions that relate to this experience. 
                    These questions should be pulled from a list such as the following:
                    Why was this experience meaningful to you?
                    Have you ever done anything like this before?
                    How did you get started?
                    How did you feel when it was complete?
                    What made this time different than other times when you were not as successful?
                    What is your favorite thing about this experience?
                    What could you learn from this experience that applies to other situations?
                    What did you learn about yourself through this experience?
                    How can you keep this experience in mind in the future?
                    5. After each question the program should pause for several seconds before continuing to the next one. 
                    While the program is paused it should display a kind of spinner.
                    6.It should continue showing random questions until it has reached the number of seconds the user specified for the duration.
                    7.The activity should conclude with the standard finishing message for all activities.
                    
                    */

            };
                int p = random.Next(prompts.Length);
                Console.WriteLine(prompts[p]);
                Console.Write("> ");

                input = Console.ReadLine();
                breatingactivity.Write(prompts[p], input);



            }

            else if (input == "3")//handels creating entries
            {
                Console.WriteLine("You have chosen the Listin activity");
                Thread.Sleep(2000);
                Console.WriteLine("This activity will help you to reflect on the good things in your life by having you list as many things as you can in a certain area.");
                Thread.Sleep(3000);
                Console.WriteLine("Below we have selected questions at random, please answer the question that has been selected. ");
                Console.WriteLine("");
                string[] prompts = new string[] {
                "Who are people that you appreciate? ",
                "What are personal strengths of yours? ",
                "Who are people that you have helped this week? ",
                "When have you felt the Holy Ghost this month? ",
                "Who are some of your personal heroes? "
            };

                int p = random.Next(prompts.Length);
                Console.WriteLine(prompts[p]);
                Console.Write("> ");

                input = Console.ReadLine();
                breatingactivity.Write(prompts[p], input);

            }
            /*  4. After displaying the prompt, the program should give them a countdown of several seconds to begin thinking about the prompt. Then, it should prompt them to keep listing items.
                5. The user lists as many items as they can until they they reach the duration specified by the user at the beginning.
                6. The activity them displays back the number of items that were entered.
                7. The activity should conclude with the standard finishing message for all activities.*/




        }
    }
}