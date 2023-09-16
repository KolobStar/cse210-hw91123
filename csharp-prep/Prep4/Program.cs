//Gloria Estrella prep 4
//List completed with demo help

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //To create a new list of integers(numbers), you specify int inside angle 
        //brackets <> directly following the name of the data structure: List<int>
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //Only add the number of thr lis if it is not 0
            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        // part 1: compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}"); // I did this =D

        // part 2: compute the average
        // Notice that we first cast the sum variable to be a float. Otherwise, because
        // both the sum and the count are integers, the computer will do integer division
        // and I will not get a decimal value (even though it puts the result into a float variable).

        // By making one of the variables a float first, the computer knows that it has to
        // do the floating point division, and we get the decimal value that we expect.
        float average =((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //part 3: Fin the max
        //There are several ways to do this, such as sorting the lsit 

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
            

        }
        Console.WriteLine($"The largest number  is: {max}");


    }
}