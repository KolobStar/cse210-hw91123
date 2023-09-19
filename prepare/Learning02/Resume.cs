using System;

//Resume class
//Create the member variable for the person's name
//Create the member variable for the list of Jobs. (Hint: the data type for this should be List<Job> , 
//and it is probably easiest to initialize this to a new list right when you declare it..)
public class Resume
{
    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: ");
        

        foreach (Job job in _jobs)
        {
            //This will call the method in each job
            job.Display();
        }
    }
}