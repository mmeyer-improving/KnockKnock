using System;

namespace KnockKnock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Knock knock!");

            string resp = Console.ReadLine();
            resp = resp.Trim();
            resp = resp.ToLower();
            
            while ((!resp.Contains("who's there") && !resp.Contains("whos there")) || resp.Length > 12)
            {
                Console.WriteLine("Knock knock!");
                resp = Console.ReadLine();
                resp = resp.ToLower();
            }

            Console.WriteLine("Mikey.");

            string resp2 = Console.ReadLine();
            resp2 = resp2.ToLower();

            while (!resp2.Contains("mikey who") || resp2.Length > 10)
            {
                Console.WriteLine("Try again.");
                resp2 = Console.ReadLine();
                resp2 = resp2.ToLower();
            }

            Console.WriteLine("My key isn't working, can you let me in?");
        }
    }
}
