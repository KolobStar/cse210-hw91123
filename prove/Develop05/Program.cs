using System;

using System.IO;

class Program
{
    static void Main(string[] args)
    {


        while (true)
        {

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal ");
            Console.WriteLine("  2. List Goals ");
            Console.WriteLine("  3. Save Goals ");
            Console.WriteLine("  4. Load Goals ");
            Console.WriteLine("  5. Record Event ");
            Console.WriteLine("  6. Quit ");
            Console.WriteLine("");
            Console.WriteLine("Select a chioce from the menu: ");
            string input = Console.ReadLine();


            if (input == "1")
            {
                Console.WriteLine("The type of Goals are: ");
                Console.WriteLine("  1. Simple Goal ");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. CheckList Goal ");
                Console.WriteLine("  4. Load Goals ");
                Console.WriteLine("Which type of goal would you like to create? ");
                Console.ReadLine();
            }
            else if (input == "2")
            {
                Console.WriteLine("The Goals are: ");

            }
            else if (input == "3")
            {
                Console.WriteLine("What is the filename for the goal file? ");
                Console.ReadLine();

            }
            else if (input == "4")
            {
                Console.WriteLine("What is the filename for the goal file? ");
                Console.ReadLine();

            }
            else if (input == "5")
            {
                Console.WriteLine("The Goals are:");
                Console.WriteLine("1. Give a talk ");
                Console.WriteLine("2. Study the scriptures ");
                Console.WriteLine("3. Atend the temple ");
                Console.WriteLine("Which goal did you acomplish? ");
                Console.ReadLine();

            }
            else if (input == "6")
            {
                break;
            }
            switch (Convert.ToInt32(input))
            {
                case 1:
                    SimpleGoal simplegoal = new SimpleGoal();
                    Console.WriteLine(simplegoal.name);
                    Console.WriteLine("");
                    Console.WriteLine(simplegoal.description);
                    Console.WriteLine("");
                    Console.WriteLine("What is the name of your goal? ");
                    input = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    input = Console.ReadLine();
                    Console.WriteLine("What is the amout of points associated with this goal? ");
                    input = Console.ReadLine();
                    break;
                case 2:
                    EternalGoal eternalGoal = new EternalGoal();
                    Console.WriteLine(eternalGoal.name);
                    Console.WriteLine("");
                    Console.WriteLine(eternalGoal.description);
                    Console.WriteLine("");
                    Console.WriteLine("What is the name of your goal? ");
                    input = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    input = Console.ReadLine();
                    Console.WriteLine("What is the amout of points associated with this goal? ");
                    input = Console.ReadLine();
                    break;
                case 3:
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    Console.WriteLine(checklistGoal.name);
                    Console.WriteLine("");
                    Console.WriteLine(checklistGoal.description);
                    Console.WriteLine("");
                    Console.WriteLine("What is the name of your goal? ");
                    input = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    input = Console.ReadLine();
                    Console.WriteLine("What is the amout of points associated with this goal? ");
                    input = Console.ReadLine();
                    Console.WriteLine("What is the bonus for acomplishing it that ");
                    input = Console.ReadLine();
                    break;
    


            };


            /*if (input == "1")
            {
                SimpleGoal simplegoal = new SimpleGoal();
                Console.WriteLine(simplegoal.name);
                Console.WriteLine("");
                Console.WriteLine(simplegoal.description);
                Console.WriteLine("");
                Console.WriteLine("What is the name of your goal? ");
                input = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                input = Console.ReadLine();
                Console.WriteLine("What is the amout of points associated with this goal? ");
                input = Console.ReadLine();
            }

            else if (input == "2")
            {
                EternalGoal eternalGoal = new EternalGoal();
                Console.WriteLine(eternalGoal.name);
                Console.WriteLine("");
                Console.WriteLine(eternalGoal.description);
                Console.WriteLine("");
                Console.WriteLine("What is the name of your goal? ");
                input = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                input = Console.ReadLine();
                Console.WriteLine("What is the amout of points associated with this goal? ");
                input = Console.ReadLine();
            }


            else if (input == "3")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal();
                Console.WriteLine(checklistGoal.name);
                Console.WriteLine("");
                Console.WriteLine(checklistGoal.description);
                Console.WriteLine("");
                Console.WriteLine("What is the name of your goal? ");
                input = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                input = Console.ReadLine();
                Console.WriteLine("What is the amout of points associated with this goal? ");
                input = Console.ReadLine();
                Console.WriteLine("What is the bonus for acomplishing it that ");
                input = Console.ReadLine();
            }*/



        }





    }
}
