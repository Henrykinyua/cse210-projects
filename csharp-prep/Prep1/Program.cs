using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what's your first name? ");
        string first = Console.ReadLine();
        
        Console.Write("What's your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}");
    }
}