using System;

class Program
{
    static void Main(string[] args)
    {
    
        Addresses a1 = new Addresses("123 Main St", "New York City", "NY");
        string add1 = a1.GetAddress();
        Lectures e1 = new Lectures("Lecture", "Speaker will share their thoughts with a life in their profession", "April 1", "5pm", $"{add1}", "John Wick", 30);
        e1.DisplayLectureDetails();

        Addresses a2 = new Addresses("321 side St", "San Diago", "CA");
        string add2 = a2.GetAddress();
        Receptions e2 = new Receptions("Reception", "Reception for the wedding", "July 24", "6pm", $"{add2}", "someone@domain.com", "123-456-78910");
        e2.DisplayReceptionDetails();

        Addresses a3 = new Addresses("123321 Half St", "Tempe", "AZ");
        string add3 = a3.GetAddress();
        OutdoorGatherings e3 = new OutdoorGatherings("Outdoor Gathering", "Gathering for the anniversary party. Dress appropriately.", "April 1", "5pm", $"{add3}", "cloudy 75 degrees");
        e3.DisplayOutdoorGatheringDetails();


    }
}