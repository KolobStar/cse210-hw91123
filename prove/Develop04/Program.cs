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
            Console.WriteLine("  1. Start Breating activity ");
            Console.WriteLine("  2. Start Reflecting activity ");
            Console.WriteLine("  3. Start Listing Activity  ");
            Console.WriteLine("  4. Quit ");
            Console.WriteLine("Select a choice from the menu: ");

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
                    Console.WriteLine("");
                    Console.WriteLine(breathingactivity._description);
                    Console.WriteLine("");
                    Console.WriteLine("How long, in seconds, would you like for your session? ");
                    input = Console.ReadLine();
                    breathingactivity._duration = Convert.ToInt32(input);//taking string and converting numbers int
                    breathingactivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingactivity = new ReflectingActivity();
                    Console.WriteLine(reflectingactivity._name);
                    Console.WriteLine("");
                    Console.WriteLine(reflectingactivity._description);
                    Console.WriteLine("");
                    Console.WriteLine("How long, in seconds, would you like for your session? ");
                    input = Console.ReadLine();
                    reflectingactivity._duration = Convert.ToInt32(input);//taking string and converting numbers int
                    reflectingactivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    Console.WriteLine(listingActivity._name);
                    Console.WriteLine("");
                    Console.WriteLine(listingActivity._description);
                    Console.WriteLine("");
                    Console.WriteLine("How long, in seconds, would you like for your session? ");
                    input = Console.ReadLine();
                    listingActivity._duration = Convert.ToInt32(input);//taking string and converting numbers int
                    listingActivity.Run();
                    break;
                case 4:
                default:
                    break;
            };


        }
    }
}