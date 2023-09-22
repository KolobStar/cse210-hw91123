//Gloria Estrella
//this file contains all the esntries

using System;

class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();//creates a list of entries
    }
// clear the entries
    public void Clear()
    {
        entries.Clear();//this clear the lists
    }

    public void Write(string prompt, string response)
    {
      Entry entry = new Entry();  
      entry.Write(prompt,response);
      entries.Add(entry);
    }

    public void Write(string prompt, string response, DateTime date)
    {
      Entry entry = new Entry(date);  
      entry.Write(prompt,response);
      entries.Add(entry);
    }

    public string Read(int index)
    {
        return entries[index].Read();//this one outputs the entries
    }
}
