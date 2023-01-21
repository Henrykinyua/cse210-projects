using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what's your grade percentage? ");
        string userGrade = Console.ReadLine();
        int percent = int.Parse(userGrade);
        
        string grade = "";

        if (percent>= 90)
        {
            grade =  "A";
        }

        else if (percent >= 80)
        {
            grade =  "B";
        } 

        else if (percent >= 70)
        {
            grade =  "C";  
        }

        else if (percent >= 60)
        {
            grade =  "D";
        } 
        else 
        {
            grade =  "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulation!, You passed the class");
        } 
        else if (percent < 70)
        {
            Console.WriteLine("Sorry you failed, there is still next time, please try harder.");
        }
    }
} 