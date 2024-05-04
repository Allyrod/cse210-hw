// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello me World!");
//         Console.WriteLine("Hello my friend!");

//         Console.WriteLine("What is your fav food?");
//         string food = Console.ReadLine();
//         Console.WriteLine($"Your fav food is {food}!");
//     }
// }

using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what is your first name? ");
        string first = Console.ReadLine();

        Console.Write("What is your lastname? ");
        string last = Console.ReadLine();

        Console.WriteLine($"your name is {last}, {first} {last})");
    }
}