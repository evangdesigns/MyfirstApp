using System;

namespace MyfirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter Your Name...");
            var userEntry = Console.ReadLine();

            Console.WriteLine(userEntry);

            Console.ReadLine();

            if (userEntry == "Nathan")
            {
                Console.WriteLine("You are aewsome");
            }
            else
            {
                Console.WriteLine("You are aewsome, but not as much");
            }

            var i = 0;

            while (i < 10)
            {
                Console.WriteLine($"Current value of i is {i++}...");
            }

            for (var j = 0; j < 10; j++)
            {
                Console.WriteLine($"Current value of i is {j}...");
            }

            foreach (var currentCharacter in userEntry)
            {
                Console.WriteLine($"the curent character is {currentCharacter}");
            }

            switch (userEntry)
            {
                case "Evan":
                    Console.WriteLine("It's Evan");
                    break;
                default:
                    Console.WriteLine("It's NOT Evan");
                    break;
            }

            var isEvan = userEntry == "Nathan" ? true : false;
        }
    }
}
