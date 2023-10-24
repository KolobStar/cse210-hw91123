using System;
class Program
{
    static void Main(string[] args)
    {

        Addresses a1 = new Addresses("6606 Quiet Quail Dr", "Missouri City", "TX");
        string add1 = a1.GetAddress();
        Lectures e1 = new Lectures("Lecture", "Speaker will share their thoughts with a life in their profession", "March 1", "7pm", $"{add1}", "John Milton", 30);
        e1.DisplayLectureDetails();
        Addresses a2 = new Addresses("!2506 South State St", "Sandy", "UT");
        string add2 = a2.GetAddress();
        Receptions e2 = new Receptions("Reception", "Reception for the graduation",
       "July 24", "6pm", $"{add2}", "star@gmail.com", "346-561-2331");
        e2.DisplayReceptionDetails();
        Addresses a3 = new Addresses("7865 Nava St", "Temecula", "California");
        string add3 = a3.GetAddress();
        OutdoorGatherings e3 = new OutdoorGatherings("Outdoor Gathering", "Gathering for the anniversary party. Dress appropriately.", "April 1", "5pm", $"{add3}", "cloudy 75 degrees");
        e3.DisplayOutdoorGatheringDetails();
    }
}