using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what's your first name? ");
        string first = Console.ReadLine();
        
        Console.WriteLine("What's your last name");
        string last = Console.ReadLine();

        Console.WriteLine($"{first}, {last} {first}");
    }
}