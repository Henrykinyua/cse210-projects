using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {  
            Console.Write("Select one of the following");
                     
            Console.WriteLine("1. write a new entry");
            Console.WriteLine("2. Display your journal");
            Console.WriteLine("3. Load your journal from a  file");
            Console.WriteLine("4. Save the journal to a file");
            Console.WriteLine("5. Exit the program");
            Console.Write("What would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Entry newEntry = new Entry();
                newEntry._prompt = GetRandomPrompt();
                Console.WriteLine('>'+newEntry._prompt);
                newEntry._response = Console.ReadLine();
                DateTime theCurrentTime = DateTime.Now;
                newEntry._date = theCurrentTime.ToShortDateString();
                journal._entries.Add(newEntry);
            }
            else if (choice == 2)
            {
                journal.Display();
            }
            else if (choice == 3)
            {
                Console.Write("Enter the filename: ");
                journal._filename = Console.ReadLine();
                journal.LoadFile();
            }
            else if (choice == 4)
            {
                Console.Write("Give a name to the file ");
                journal._filename = Console.ReadLine();
                journal.SaveFile();
            }
            else if (choice == 5)
            {
                break;
            }
             
        }
        static string GetRandomPrompt()
        {
            List<string> prompts = new List<string>()
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}