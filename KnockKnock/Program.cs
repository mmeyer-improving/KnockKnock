using System;

namespace KnockKnock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Knock knock!");

            string resp = Console.ReadLine();
            resp = resp.ToLower();
            
            //TODO: Add further validation? Currently works even if you have stuff before or after the "who's there" i.e. akfhkfhkglhlkwho's there
            while (!resp.Contains("who's there") && !resp.Contains("whos there"))
            {
                Console.WriteLine("Knock knock!");
                resp = Console.ReadLine();
                resp = resp.ToLower();
            }

            Console.WriteLine("Mikey.");

            string resp2 = Console.ReadLine();
            resp2 = resp2.ToLower();

            //Same as above, probably needs further validation & a refactor
            while (!resp2.Contains("mikey who"))
            {
                Console.WriteLine("Try again.");
                resp2 = Console.ReadLine();
                resp2 = resp2.ToLower();
            }

            Console.WriteLine("My key isn't working, can you let me in?");
        }
    }
}
