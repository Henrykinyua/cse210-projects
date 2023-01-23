using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        Console.WriteLine($"Magic number is {magicNumber}");

        int guess = -1;
        while (guess != magicNumber)
        {   
            Console.Write("What is your guess? ");
            string userNumber = Console.ReadLine();
            guess = int.Parse(userNumber);                                      
            
            if (guess <  magicNumber)
            {
                Console.WriteLine("Higher");   
            }
            
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
            }
        }    
    }
}