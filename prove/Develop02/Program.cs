//Gloria Estrella
//Main File
using System;
//the IO helps to work read and write other files
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //journals cotain entries
        Journal journal = new Journal();
        //to get a random numbers 
        Random random = new Random();

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display ");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do? ");
            string input = Console.ReadLine();
            // handle the quit choice
            if (input == "5")
            {
                break;
            }

            else if (input == "1")//handels creating entries
            {

                string[] prompts = new string[] {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day? ",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today? ",
                "If I had one thing I could do over today, what would it be?"

            };

                int p = random.Next(prompts.Length);
                Console.WriteLine(prompts[p]);
                Console.Write("> ");

                input = Console.ReadLine();
                journal.Write(prompts[p], input);

            }

            else if (input == "2")
            {
                for (int I = 0; I < journal.entries.Count; I++)
                {
                    Console.WriteLine("Entry " + (I + 1));
                    Console.WriteLine(journal.Read(I));
                    Console.WriteLine();
                }
            }
            else if (input == "3")
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                journal.Clear();
                foreach (string line in lines)
                {
                    string[] parts = line.Split("~~");

                    DateTime date = DateTime.Parse( parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];
                    journal.Write(prompt, response, date);
                }
            }
            else if (input == "4")
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))//takes the file name and puts the text on it
                {
                    for (int I = 0; I < journal.entries.Count; I++)
                    {
                        outputFile.WriteLine(journal.entries[I].ToString());
                    }



                }
            }
        }
    }
}

                

