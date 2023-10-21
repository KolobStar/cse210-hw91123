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
            Console.WriteLine("Select a Cleaning or Service Option ");
            Console.WriteLine("Service Options: ");
            Console.WriteLine("  1. Basic Service ");
            Console.WriteLine("  2. Economic Service ");
            Console.WriteLine("  3. Platinium Service  ");
            Console.WriteLine("  4. Gold Service");
            Console.WriteLine("  5. HVAC Service ");
            Console.WriteLine("  6. Plumbing Service ");
            Console.WriteLine("  7. Electric Service");
            Console.WriteLine("  8. Quit ");

            string input = Console.ReadLine();

            if (input == "8")// handle the quit choice
            {
                break;
            }

            switch (Convert.ToInt32(input))
            {
                case 1:
                    
                    break;
                case 2:
                   
                    break;
                case 3:
                    
                    break;
                case 4:
                default:
                    break;
            };


        }
    }
}