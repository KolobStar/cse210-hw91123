//Gloria Estrella
//this file contains all the esntries

using System;


    class BreatingActivity : Activity
    {
        public List<Activity> entries;

        public BreatingActivity()
        {
            entries = new List<Activity>();//creates a list of entries
        }

        public void Run()
        {

        }

    // clear the entries
        public void Clear()
        {
            entries.Clear();//this clear the lists
        }

        // public void Write(string prompt, string response)
        // {
        // Activity activity = new Activity();  
        // activity.Write(prompt,response);
        // entries.Add(activity);
        // }

        public void Write(string prompt, string response, DateTime date)
        {
        Activity activity = new Activity(date);  
        activity.Write(prompt,response);
        entries.Add(activity);
        }

        public string Read(int index)
        {
            return entries[index].Read();//this one outputs the entries
        }
    }
