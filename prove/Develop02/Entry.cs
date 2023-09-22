//Gloria Estrella
//This file contains the data of the entries 
using System;

class Entry 
{
    public string prompt;
    public string response;
    public DateTime date;

    public Entry()
    {
       this.date  = DateTime.Now;// thisone stores the date when is created
    }

     public Entry(DateTime date)
    {
       this.date  = date;// thisone stores the date from the loaded file
    }

    public void Write(string prompt, string response)//stores the prompt and response of the input
    {
        this.prompt = prompt;
        this.response = response;

        
    }
    public string Read()
    {
        return date + "\n" + prompt + "\n" + response;
    
    }

    public override string ToString()
    {
        return date + "~~" + prompt + "~~" + response;// creates string foer saving and loading  with the IO
    }



}