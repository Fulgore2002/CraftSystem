using System;

namespace CraftSystem
{
    public class Library
    {
        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        public static string GetUserInput(string prompt)
        {
            Print(prompt);
            return Console.ReadLine();
        }

        public static bool IsNumber(string input)
        {
            return double.TryParse(input, out _);
        }
    }
}
