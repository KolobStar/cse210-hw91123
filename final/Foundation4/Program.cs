using System;
class Program
{
    static void Main(string[] args)
    {
        Running r1 = new Running("May 1", 35, 35);
        r1.DisplaySummary();
        Cycling c1 = new Cycling("May 2", 15, 15);
        c1.DisplaySummary();
        Swimming s1 = new Swimming("May 3", 20, 20);
        s1.DisplaySummary();
    }
}