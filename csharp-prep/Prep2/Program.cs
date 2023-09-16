using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter your grade percentage: ");
        string ValueFromUser =Console.ReadLine();
        int percentage =int.Parse(ValueFromUser);

        string letter = "";

        if (percentage >= 90)
        {
            letter ="A";
        }
        else if(percentage>= 80)
        {
            letter = "B";
        }
        else if(percentage>= 70)
        {
            letter = "C";
        }
        else if(percentage>= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.Write("Better luck next time!");
        }
         

    }


    
}