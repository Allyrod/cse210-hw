using System;

public class Program
{
    public static void Main(string[] args)
    {
        Address lectureAddress = new Address("60 N Temple", "Salt Lake City", "UT", "84150");
        Lecture lecture = new Lecture("Tech Talk", "A talk on the latest tech trends", new DateTime(2024, 8, 1), "10:00 AM", lectureAddress, "Jane Doe", 100);

        Address receptionAddress = new Address("299 S Main St", "Salt Lake City", "UT", "84111");
        Reception reception = new Reception("Company Gala", "Annual company celebration", new DateTime(2024, 8, 15), "7:00 PM", receptionAddress, "rsvp@company.com");

        Address outdoorAddress = new Address("2330 E Bengal Blvd", "Cottonwood Heights", "UT", "84121");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Picnic in the Park", "A fun day in the park with family and friends", new DateTime(2024, 9, 5), "11:00 AM", outdoorAddress, "Sunny");

        // Print details for each event
        Console.WriteLine();
        Console.WriteLine(lecture.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.FullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture.ShortDescription());
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine(reception.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.FullDetails());
        Console.WriteLine();
        Console.WriteLine(reception.ShortDescription());
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.StandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.FullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.ShortDescription());
        Console.WriteLine();
    }
}